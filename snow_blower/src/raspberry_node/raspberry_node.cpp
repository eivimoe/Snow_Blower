/*
    Eivind Moe - eivimoe@hotmail.com
    Lars Olav Brekke - larsolav94@hotmail.com
 */


#include "ros/ros.h"
#include "std_msgs/String.h"
#include <sstream>

void arduino_Callback(const std_msgs::String::ConstPtr& arduino_msg)
{
    ROS_INFO(" I heard: [%s]\n", arduino_msg->data.c_str());
}


int main(int argc, char **argv)
{
	// Initiate new ROS node named "raspberry_pi"
	ros::init(argc, argv, "raspberry_pi");

	//create a node handle: it is reference assigned to a new node
	ros::NodeHandle n;
	//create a publisher with a topic "chatter" that will send a String message
	ros::Publisher pub = n.advertise<std_msgs::String>("robot_movement", 1000);

    //Create a new subscriber with topic name "robot_feedback"
    ros::Subscriber sub = n.subscribe("robot_feedback", 1000, arduino_Callback); 

	//Rate is a class the is used to define frequency for a loop. Here we send a message each two seconds.
	ros::Rate loop_rate(1); //1 message per second

   while (ros::ok()) // Keep spinning loop until user presses Ctrl+C
   {
       //create a new String ROS message.
	   //Message definition in this link http://docs.ros.org/api/std_msgs/html/msg/String.html
	   std_msgs::String msg;

       //create a string for the data
	   std::stringstream ss;
       
       ss << "mf_55";

	   //assign the string data to ROS message data field
       msg.data = ss.str();

       //Publish the message
       pub.publish(msg);
       //pub.publish("mf_55");

       ros::spinOnce(); // Need to call this function often to allow ROS to process incoming messages

      loop_rate.sleep(); // Sleep for the rest of the cycle, to enforce the loop rate
   }
   return 0;
}


