using ROSBridgeLib.std_msgs;
using ROSBridgeLib.geometry_msgs;
using SimpleJSON;

namespace ROSBridgeLib
{
    namespace move_base_msgs
    {
        public class MoveBaseGoalMsg : ROSBridgeMsg
        {
            private PoseStampedMsg target_pose;
            public MoveBaseGoalMsg(JSONNode msg)
            {
                target_pose = new PoseStampedMsg(msg["target_pose"]);
            }

            public MoveBaseGoalMsg(PoseStampedMsg _target_pose)
            {
                target_pose = _target_pose;
            }

            public static string GetMessageType()
            {
                return "move_base_msgs/MoveBaseGoal";
            }

            public override string ToString()
            {
                return "move_base_msgs/MoveBaseGoal [target_pose=" + target_pose.ToString();
            }


            public override string ToYAMLString()
            {
                return "{\"target_pose\":" + target_pose.ToYAMLString() + "}";
            }

            public PoseStampedMsg GetTargetPose()
            {
                return target_pose;
            }

        }
    }
}