/*
    Eivind Moe - eivimoe@hotmail.com
    Lars Olav Brekke - larsolav94@hotmail.com
 */



#include "ros/ros.h"
#include "sensor_msgs/LaserScan.h"
#include "laserscan/LaserScanner.h"
#include "std_msgs/String.h"
#include <sstream>
#include <string>


using namespace std;

//Define subscribers and publishers
ros::Subscriber scanSubscriber;
ros::Subscriber arduinoSubscriber;

ros::Publisher arduinoPublisher;

//msgs string for arduino communication
std_msgs::String msg;

//create a string for the data
std::stringstream ss;

bool obstacleTooClose;
string prevArduinoResponse;

void scanCallback (sensor_msgs::LaserScan scanMessage);
void arduino_Callback(const std_msgs::String::ConstPtr& arduino_msg);
void avoidObstacle();
void publishToArduino(string command);


int main(int argc, char **argv){
    obstacleTooClose = false;

	// Initiate new ROS node named "raspberry_pi"
	ros::init(argc, argv, "raspberry_pi");
	ros::NodeHandle n;

    //create a publisher with a topic "robot_movement" that will send a String message
	arduinoPublisher = n.advertise<std_msgs::String>("robot_movement", 1000);

	//subscribe to the laser scanner topic
	scanSubscriber = n.subscribe("/scan", 10, scanCallback);

    //Create a new subscriber with topic name "robot_feedback"
    arduinoSubscriber = n.subscribe("robot_feedback", 1000, arduino_Callback); 

	
	//Rate is a class the is used to define frequency for a loop. Here we send a message each second.
	ros::Rate loop_rate(1); //1 message per second

    while (ros::ok()) // Keep spinning loop until user presses Ctrl+C
    {
	   //Message definition in this link http://docs.ros.org/api/std_msgs/html/msg/String.html
        
        //if lidar detects object, full stop. else move forward
        if (obstacleTooClose || prevArduinoResponse != ss.str()){
            avoidObstacle();
        }
        else {
            publishToArduino("mf_90");
        }

       ros::spinOnce(); // Need to call this function often to allow ROS to process incoming messages

      loop_rate.sleep(); // Sleep for the rest of the cycle, to enforce the loop rate
   }
   return 0;
}

void scanCallback (sensor_msgs::LaserScan scanMessage){
	//cout<<"minimum range: " <<LaserScanner::getMinimumRange(scanMessage)<<endl;
    //cout<<"maximum range: " <<LaserScanner::getMaximumRange(scanMessage)<<endl;
    //cout<<"average range: " <<LaserScanner::getAverageRange(scanMessage,0,600)<<endl;
    if (LaserScanner::isObstacleTooClose(scanMessage,0,360,0.30)==true){
        obstacleTooClose = true;
    }
    cout<<endl;

}

void arduino_Callback(const std_msgs::String::ConstPtr& arduino_msg)
{
    prevArduinoResponse = "";
    prevArduinoResponse = arduino_msg->data.c_str();
}

void avoidObstacle(){
    publishToArduino("a");
    //implement function to turn according to angle where object is detected
    //publishToArduino("mr_90");

}

void publishToArduino(string command){
    ss << "";
    ss << command;

	//assign the string data to ROS message data field
    msg.data = ss.str();

    //Publish the message
    arduinoPublisher.publish(msg);
}

