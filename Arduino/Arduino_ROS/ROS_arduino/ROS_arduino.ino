// Servo - Version: Latest
#include <Servo.h>

// L298N - Version: 1.1.0
//#include <L298N.h>

// Include ros-dependant libraries
#include <ros.h>
#include <std_msgs/String.h>

/*
  Code for controlling the platform for snow robot project
*/
//defining pins for motor driver
//motor A1 and 2
#define enA 6
#define in1 49
#define in2 48
//motor B1 and 2
#define enB 7
#define in3 43
#define in4 42
//motor C - Snowblower
#define enC 8
//#define in5 50
//#define in6 51
/*//motor D - Brush
  #define enD 18
  #define in7 52
  #define in8 53
*/

Servo snowBlower;
Servo snowblowerMotor;
Servo chuteAngle;
Servo chuteRotation;
Servo brushAngle;
Servo brushRotation;
//Servo brushMotor;

int brushRot = 90;
char incomingByte;
char part;
char function;
int value = -1;
char inData[5];
byte index = 0;

// Initialize ROS node & publisher
ros::NodeHandle nh;

std_msgs::String str_msg;
ros::Publisher chatter("robot_feedback", &str_msg);

void messageCb(const std_msgs::String& toggle_msg) {
  char[] temp = toggle_msg;

  part = temp[0];
  function = temp[1];
  value = atoi(temp[3] + temp[4]);
}
ros::Subscriber<std_msgs::String> sub("robot_movement", &messageCb);

void setup()
{
  //Init ros node
  nh.initNode();
  nh.advertise(chatter);
  nh.subscribe(sub);
  //motors

  pinMode(enA, OUTPUT);
  pinMode(enB, OUTPUT);
  pinMode(enC, OUTPUT);
  //  pinMode(enD, OUTPUT);
  pinMode(in1, OUTPUT);
  pinMode(in2, OUTPUT);
  pinMode(in3, OUTPUT);
  pinMode(in4, OUTPUT);
  //pinMode(in5, OUTPUT);
  //pinMode(in6, OUTPUT);
  //  pinMode(in7, OUTPUT);
  //  pinMode(in8, OUTPUT);

  //servos
  snowBlower.attach(36);
  snowBlower.write(90);
  chuteAngle.attach(33);
  chuteRotation.attach(32);
  brushAngle.attach(35);
  brushAngle.write(75);
  brushRotation.attach(34);
  brushRotation.write(90);
  snowblowerMotor.attach(37);
  //  brushMotor.attach(37);

  str_msg.data = hello;
  chatter.publish(&str_msg);
}

/**
   Functions for movement of snowblower
**/
void goForward(int pwm)
{
  //set Motor A Forward
  digitalWrite(in1, LOW);
  digitalWrite(in2, HIGH);
  analogWrite(enA, pwm);
  // Set Motor B forward
  digitalWrite(in3, LOW);
  digitalWrite(in4, HIGH);
  analogWrite(enB, pwm);
}

void goBackward(int pwm)
{
  //set Motor A Backwards
  digitalWrite(in1, HIGH);
  digitalWrite(in2, LOW);
  analogWrite(enA, pwm);
  // Set Motor B backwards
  digitalWrite(in3, HIGH);
  digitalWrite(in4, LOW);
  analogWrite(enB, pwm);
}

void fullStop(int pwm)
{
  //set Motor A STOP
  digitalWrite(in1, LOW);
  digitalWrite(in2, LOW);
  analogWrite(enA, pwm);
  // Set Motor B STOP
  digitalWrite(in3, LOW);
  digitalWrite(in4, LOW);
  analogWrite(enB, pwm);
}

void turnLeft(int pwm)
{
  //set Motor A Forward
  digitalWrite(in1, LOW);
  digitalWrite(in2, HIGH);
  analogWrite(enA, pwm);
  //set Motor B Backwards
  digitalWrite(in3, HIGH);
  digitalWrite(in4, LOW);
  analogWrite(enB, pwm);
}

void turnRight(int pwm)
{
  //set Motor A backwards
  digitalWrite(in1, HIGH);
  digitalWrite(in2, LOW);
  analogWrite(enA, pwm);
  //set Motor B forwards
  digitalWrite(in3, LOW);
  digitalWrite(in4, HIGH);
  analogWrite(enB, pwm);
}

/**
   Functions for Snowblower
**/

void stopSnowblower()
{
  int sbangle = map(45, 0, 100, 0, 180);
  snowblowerMotor.write(sbangle);
  delay(500);
}

void runSnowblower(int motorSpeed)
{
  int sbangle;

  for (int setmotorSpeed = 0; setmotorSpeed <= motorSpeed; setmotorSpeed += 5) {
    sbangle = map(setmotorSpeed, 0, 100, 90, 180);
    snowblowerMotor.write(sbangle);
    delay(200);
  }
  // }
  //}
}

//Max Angle is currently 45, but could be set to less, depending on how far it should be possible to lift it.
void liftSnowblower(int angle)
{
  snowBlower.write(angle);
  //if (angle <= 45) {
  //    snowBlower.write(angle);
  //}
  //else if (angle > 45) {
  //    snowBlower.write(45);
  //}
  delay(5);
}

void resetSnowblower()
{
  snowBlower.write(0);
  delay(5);
}

//0 to 180
void setChuteAngle(int angle)
{
  chuteAngle.write(angle);
  delay(5);
}
//0 to 180
void setChuteRotation(int angle)
{
  chuteRotation.write(angle);
  //  Serial.println("angle recieved");
  //  Serial.println(angle);
  delay(5);
}

void areset()
{
  for (int i; i > 5; i++) {
    inData[i] = 0;
    delay(1);
  }
  value = -1;
  index = 0;
  delay(5);
  str_msg.data = reset finished;
  chatter.publish(&str_msg);
}

void reset() {}


void loop()
{
  delay(25);
  // (part)
  //case default stand still
  /*
    MOVEMENT
  */

  if (part == 'm' && value >= 0) {

    //    Serial.println("function:");
    //    Serial.println(function);
    //    Serial.println("value:");
    //    Serial.println(value);
    //    Serial.println("part:");
    //    Serial.println(part);

    switch (function) {

      case 'f':
        goForward(value);
        //Serial.println("Case - f");
        //Serial.println(value);
        reset();
        //delay(500);
        // fullStop(0);
        break;

      //turn left
      case 'l':
        turnLeft(value);
        str_msg.data = Case - l;
        reset();
        break;

      //case turn right
      case 'r':
        turnRight(value);
        str_msg.data = Case - r;
        reset();
        break;

      //case reverse
      case 'b':
        goBackward(value);
        str_msg.data = Case - b;
        reset();
        break;

      //case stop
      case 's':
        fullStop(0);
        str_msg.data = Case - s;
        reset();
        break;

      default:
        fullStop(0);
        str_msg.data = Case - def;
        reset();
        break;
    }
  }

  /*
    SNOWBLOWER
  */
  else if (part == 's' && value >= 0) {
    switch (function) {
      //case turn off snowblower off

      case 's':
        stopSnowblower();
        str_msg.data = Case - s;
        reset();
        break;

      //case on - motor C
      case 'r':
        runSnowblower(value);
        str_msg.data = Case - r;
        reset();
        break;

      //case lift
      case 'l':
        liftSnowblower(value);
        str_msg.data = Case - l;
        reset();
        break;

      //reset lift
      case 'R':
        resetSnowblower();
        str_msg.data = Case - R;
        reset();
        break;

      //case direction (left-right) shute
      case 'd':
        setChuteRotation(value);
        str_msg.data = Case - d;
        //areset();

        for (int i; i > 5; i++) {
          inData[i] = 0;
          delay(1);
        }
        value = -1;
        index = 0;
        delay(5);

        break;
      //case angle (up-down) shute

      case 'a':
        setChuteAngle(value);
        str_msg.data = Case - a;
        reset();
        break;

      default:
        str_msg.data = Case - def;
        reset();
        //stopSnowblower(0);
        break;
    }
  }
  chatter.publish(&str_msg);
}

// Prevent buzzing at low speeds (Adjust according to your motors. My motors couldn't start moving if PWM value was below value of 70)
//if (motorSpeedA < 70) {
//  motorSpeedA = 0;
// }
// if (motorSpeedB < 70) {
//   motorSpeedB = 0;
// }
