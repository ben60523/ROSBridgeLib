using ROSBridgeLib.std_msgs;
using SimpleJSON;

namespace ROSBridgeLib
{
    namespace actionlib_msgs
    {
        public class GoalIDMsg : ROSBridgeMsg
        {
            private TimeMsg _stamp;
            private string _id;

            public GoalIDMsg(JSONNode msg)
            {
                _stamp = new TimeMsg(msg["stamp"]);
                _id = msg["id"].ToString();
            }

            public static string GetMessageType()
            {
                return "actionlib_msgs/GoalID";
            }
        }
    }
}