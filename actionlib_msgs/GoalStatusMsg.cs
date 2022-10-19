using ROSBridgeLib.std_msgs;
using ROSBridgeLib.actionlib_msgs;
using SimpleJSON;

namespace ROSBridgeLib
{
    namespace actionlib_msgs
    {
        public class GoalStatusMsg : ROSBridgeMsg
        {
            private GoalIDMsg _goal_id;
            private int _status;
            private string _text;
            public GoalStatusMsg(JSONNode msg)
            {
                _goal_id = new GoalIDMsg(msg["goal_id"]);
                _status = int.Parse(msg["status"]);
                _text = msg["text"];
            }

            public static string GetMessageType()
            {
                return "actionlib_msgs/GoalStatus";
            }

            public StatusType GetStatus()
            {
                return (StatusType)_status;
            }
        }
    }
}