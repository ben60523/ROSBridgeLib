using ROSBridgeLib.std_msgs;
using ROSBridgeLib.actionlib_msgs;
using ROSBridgeLib.geometry_msgs;
using SimpleJSON;

namespace ROSBridgeLib
{
    namespace move_base_msgs
    {
        public class MoveBaseActionGoalMsg : ROSBridgeMsg
        {
            private HeaderMsg header;
            private GoalIDMsg goal_id;
            private MoveBaseGoalMsg goal;
            public MoveBaseActionGoalMsg(JSONNode msg)
            {
                header = new HeaderMsg(msg["header"]);
                goal_id = new GoalIDMsg(msg["goal_id"]);
                goal = new MoveBaseGoalMsg(msg["goal"]);
            }

            public MoveBaseActionGoalMsg(HeaderMsg _header, GoalIDMsg _goal_id, MoveBaseGoalMsg _goal)
            {
                header = _header;
                goal_id = _goal_id;
                goal = _goal;
            }

            public static string GetMessageType()
            {
                return "move_base_msgs/MoveBaseActionGoal";
            }

            public override string ToString()
            {
                return "move_base_msgs/MoveBaseActionGoal [header=" + header.ToString() +
                                                        ", goal_id=" + goal_id.ToString() +
                                                        ", goal=" + goal.ToString();
            }

            public override string ToYAMLString()
            {
                return "{\"header\": " + header.ToYAMLString() +
                        "\"goal_id\": " + goal_id.ToYAMLString() +
                        "\"goal\": " + goal.ToYAMLString() + "}";
            }

            public MoveBaseGoalMsg GetGoal()
            {
                return goal;
            }

            public PoseStampedMsg GetGoalPose()
            {
                return goal.GetTargetPose();
            }
        }
    }
}