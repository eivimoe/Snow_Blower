cmake_minimum_required(VERSION 2.8.3)
project(snow_blower)

## Find catkin macros and libraries
find_package(catkin REQUIRED COMPONENTS
  roscpp
  rospy
  std_msgs
  message_generation
)

## Generate added messages and services with any dependencies listed here
 generate_messages(
   DEPENDENCIES
   std_msgs
 )


###################################
## catkin specific configuration ##
###################################
catkin_package(
  INCLUDE_DIRS include
  LIBRARIES snow_blower
  CATKIN_DEPENDS roscpp rospy std_msgs message_runtime laserscan
  #DEPENDS system_lib
)

###########
## Build ##
###########

## Specify additional locations of header files
## Your package locations should be listed before other locations
include_directories(
# include
  ${catkin_INCLUDE_DIRS}
)


add_library(utility_library src/laserscan/utility_library.cpp)

#LaserScan
add_library(laserscan_library src/laserscan/LaserScanner.cpp)
target_link_libraries(laserscan_library ${catkin_LIBRARIES})
add_dependencies(laserscan_library ${catkin_EXPORTED_TARGETS})
target_link_libraries(laserscan_library utility_library)

#talker
#add_executable(talker_node src/talker_listener/talker.cpp)
#target_link_libraries (talker_node ${catkin_LIBRARIES})

#listener
#add_executable(listener_node src/talker_listener/listener.cpp)
#target_link_libraries (listener_node ${catkin_LIBRARIES})

add_executable(scan_subscriber_cpp src/scan_subscriber.cpp)
target_link_libraries(scan_subscriber_cpp ${catkin_LIBRARIES})
target_link_libraries(scan_subscriber_cpp laserscan_library)