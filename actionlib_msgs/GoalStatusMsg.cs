using ROSBridgeLib.std_msgs;
using ROSBridgeLib.actionlib_msgs;
using SimpleJSON;

namespace ROSBridgeLib
{
    namespace actionlib_msgs
    {
        public class GoalStatusMsg : ROSBridgeMsg
        {
            private GoalIDMsg goal_id;
            private int status;
            private string text;
            public GoalStatusMsg(JSONNode msg)
            {
                goal_id = new GoalIDMsg(msg["goal_id"]);
                status = int.Parse(msg["status"]);
                text = msg["text"];
            }

            public GoalStatusMsg(GoalIDMsg _goal_id, int _status, string _text)
            {
                goal_id = _goal_id;
                status = _status;
                text = _text;
            }

            public static string GetMessageType()
            {
                return "actionlib_msgs/GoalStatus";
            }

            public override string ToString()
            {
                return "actionlib_msgs/GoalStatus [goal_id=" + goal_id.ToString() + ", status=" + status.ToString() + ", text=" + text;
            }

            public override string ToYAMLString()
            {
                return "{\"goal_id\": " + goal_id.ToYAMLString() + ", \"status\": " + status.ToString() + ", \"text\": " + text + "}";
            }

            public StatusType GetStatus()
            {
                return (StatusType)status;
            }
        }
    }
}