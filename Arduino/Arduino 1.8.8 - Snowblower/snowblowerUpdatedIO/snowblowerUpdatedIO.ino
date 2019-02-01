// Servo - Version: Latest
#include <Servo.h>

// L298N - Version: 1.1.0
//#include <L298N.h>

/*
  Code for controlling the platform for snow robot project
*/
//defining pins for motor driver
//motor A1 and 2 - belt left side
#define enA 6
#define in1 47
#define in2 46
//motor B1 and 2 - belt right side
#define enB 7
#define in3 43
#define in4 42
//motor C - Snowblower
#define enC 8
#define in5 50
#define in6 51
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


void setup()
{
    //motors
    pinMode(enA, OUTPUT);
    pinMode(enB, OUTPUT);
    analogWrite(enB, 255);
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
    chuteAngle.write(90);   // asd
    chuteRotation.attach(32);
    chuteRotation.write(92); // asd

    /*
    brushAngle.attach(35);
	brushAngle.write(90); // 75
  
    brushRotation.attach(34);
	brushRotation.write(90);
 */
    snowblowerMotor.attach(37);
  //  brushMotor.attach(37);

    Serial.begin(9600);
    Serial.println("Hello world!");
    //Serial.flush();
}

/**
   Functions for movement of snowblower

   *PWM is mapped to account for the motor drivers reverse PWM signal*
**/
void goForward(int pwm)
{
  digitalWrite(in1, HIGH);
  digitalWrite(in2, LOW);
  //analogWrite(enA, pwm);
  //analogWrite(enB, pwm);

  /*
    //set Motor A Forward
    digitalWrite(in1, LOW);
    digitalWrite(in2, HIGH);
    // Set Motor B forward
    digitalWrite(in3, LOW);
    digitalWrite(in4, HIGH);
    analogWrite(enA, pwm);
    analogWrite(enB, pwm);
    */
}

void goBackward(int pwm)
{
  digitalWrite(in1, LOW);
  digitalWrite(in2, HIGH);
  //analogWrite(enA, pwm);
  //analogWrite(enB, pwm);
  /*
    //set Motor A Backwards
    digitalWrite(in1, HIGH);
    digitalWrite(in2, LOW);
    analogWrite(enA, pwm);
    // Set Motor B backwards
    digitalWrite(in3, HIGH);
    digitalWrite(in4, LOW);
    analogWrite(enB, pwm);
    */
}

void fullStop(int pwm)
{
  digitalWrite(in1, LOW);
  digitalWrite(in2, LOW);
  //analogWrite(enA, pwm);
  //analogWrite(enB, pwm);
  /*
    //set Motor A STOP
    digitalWrite(in1, LOW);
    digitalWrite(in2, LOW);
    analogWrite(enA, pwm);
    // Set Motor B STOP
    digitalWrite(in3, LOW);
    digitalWrite(in4, LOW);
    analogWrite(enB, pwm);
    */
}

void turnLeft(int pwm)
{
  digitalWrite(in1, HIGH);
  digitalWrite(in2, HIGH);
  //analogWrite(enA, pwm);
  //analogWrite(enB, pwm);
  /*
    //set Motor A Forward
    digitalWrite(in1, HIGH);
    digitalWrite(in2, LOW);
    analogWrite(enA, pwm);
    //set Motor B Backwards
    digitalWrite(in3, LOW);
    digitalWrite(in4, HIGH);
    analogWrite(enB, pwm);
    */
}

void turnRight(int pwm)
{
    //set Motor A backwards
    digitalWrite(in1, LOW);
    digitalWrite(in2, HIGH);
    analogWrite(enA, pwm);
    //set Motor B forwards
    digitalWrite(in3, HIGH);
    digitalWrite(in4, LOW);
    analogWrite(enB, pwm);
}

/**
   Functions for Snowblower
**/

void stopSnowblower()
{ 
    runSnowblower(0);
    //int sbangle = map(45, 0, 100, 0, 180);
    //snowblowerMotor.write(sbangle);
    //delay(500);
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
/**
   Functions for Brush
**/

void stopBrush()
{   
        //set Motor C Backwards
    analogWrite(enC, 0);

}
void runBrush(int pwm)
{
        //set Motor C Backwards
    analogWrite(enC, pwm);

    } 

//Max angle of 45
void setBrushAngle(int angle)
{
    //if (angle <= 45) {
        brushAngle.write(angle);
    //}
    //else if (angle > 45) {
   //     brushAngle.write(45);
   // }
}

void resetBrushAngle()
{
    brushAngle.write(75);
}

//mounted at 90, can rotate 45 degrees both ways, but only has 2 pre-set rotations to avoid problems.
void setBrushDirection(int rot)
{
    
    if (rot == 1) {
        brushRotation.write(135);
    }
    else if (rot == 2) {
        brushRotation.write(45);
     }
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
    Serial.println("reset() finished");
}

void reset() {}


void loop()
{
    //Receive message from COM port
    //Decode the message and assign value for variable of the switch cases
    if (Serial.available() > 0) {
        Serial.print("Serial: ");
        Serial.println(Serial.available());
        if (index > 2) {
            value = Serial.parseInt();
        }
        else if (index < 2) {
            inData[index] = Serial.read();
        }
        //Serial.println("Serial Read:");
        //    Serial.println(inData[index]);
        //    Serial.println(index);
        index++;
        part = inData[0];
        function = inData[1];
      
    }
//    Serial.print("Part: ");
//        Serial.println(part);
//        Serial.print("Func: ");
//        Serial.println(function);
//        Serial.print("Value: ");
//        Serial.println(value);
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
            Serial.println("Go forward");
            //Serial.println(value);
            reset();
            //delay(500); // Necessary? Go forward for how long?
           // fullStop(0);
            break;

        //turn left
        case 'l':
            turnLeft(value);
            Serial.println("Go left");
            reset();
            break;

        //case turn right
        case 'r':
            turnRight(value);
            Serial.println("Go right");
            reset();
            break;

        //case reverse
        case 'b':
            goBackward(value);
            Serial.println("Go back");
            reset();
            break;

        //case reverse
        case 's':
            fullStop(0);
            Serial.println("Stop");
            //areset();
            break;

        default:
            fullStop(0);
            Serial.println("function:");
            Serial.println(function);
            Serial.println("value:");
            Serial.println(value);
            Serial.println("part:");
            Serial.println(part);
            Serial.println("Case - default");
            //areset();
            break;
        }
        areset();
    }

    /*
     SNOWBLOWER
    */
    else if (part == 's' && value >= 0) {
        switch (function) {
        //case turn off snowblower off

        case 's':
            stopSnowblower();
            Serial.println("Stop SB");
            reset();
            break;

        //case on - motor C
        case 'r':
            runSnowblower(value);
            Serial.println("Run SB");
            reset();
            break;

        //case lift
        case 'l':
            liftSnowblower(value);
            Serial.println("Lift SB");
            reset();
            break;

        //reset lift
        case 'R':
            resetSnowblower();
            Serial.println("Reset SB");
            reset();
            break;

        //case direction (left-right) shute
        case 'd':
            setChuteRotation(value);
            Serial.println("Set Rot");
            //areset();   
            break;
        //case angle (up-down) shute

        case 'a':
            setChuteAngle(value);
            Serial.println("Set Angl");
            //areset();
            break;

        default:
            Serial.println("Case - default");
            reset();
            //stopSnowblower(0);
            break;
        }
        areset();
    }

    /*
     BRUSH
    */

    else if (part == 'b' && value >= 0) {
        switch (function) {
        //case default off
        case 's':
            stopBrush();
            Serial.println("Stop brush");
            reset();
            break;

        //case on
        case 'r':
            Serial.println("Run brush");
            runBrush(value);
            reset();
            break;

        //case direction (left-right)
        case 'd':
            Serial.println("Brush Dir");
            setBrushDirection(value); //1 for left, 2 for right
            reset();
            break;
        //case angle (up-down)

        case 'a':
            Serial.println("Brush Angl");
            setBrushAngle(value);
            reset();
            break;

        //reset Brush Angle
        case 'R':
            Serial.println("Reset BAngl");
            resetBrushAngle();
            reset();
            break;

        default:
            Serial.println("Case - default");
            stopBrush();
            reset();
            break;
            
        }
        areset();
    }
}

// Prevent buzzing at low speeds (Adjust according to your motors. My motors couldn't start moving if PWM value was below value of 70)
//if (motorSpeedA < 70) {
//  motorSpeedA = 0;
// }
// if (motorSpeedB < 70) {
//   motorSpeedB = 0;
// }
