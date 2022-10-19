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
            private HeaderMsg _header;
            private GoalIDMsg _goal_id;
            private MoveBaseGoalMsg _goal;
            public MoveBaseActionGoalMsg(JSONNode msg)
            {
                _header = new HeaderMsg(msg["header"]);
                _goal_id = new GoalIDMsg(msg["goal_id"]);
                _goal = new MoveBaseGoalMsg(msg["goal"]);
            }

            public MoveBaseGoalMsg GetGoal()
            {
                return _goal;
            }

            public static string GetMessageType()
            {
                return "move_base_msgs/MoveBaseActionGoal";
            }
            public PoseStampedMsg GetGoalPose()
            {
                return _goal.GetTargetPose();
            }
        }
    }
}