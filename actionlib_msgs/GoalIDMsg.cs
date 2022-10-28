using ROSBridgeLib.std_msgs;
using SimpleJSON;

namespace ROSBridgeLib
{
    namespace actionlib_msgs
    {
        public class GoalIDMsg : ROSBridgeMsg
        {
            private TimeMsg time;
            private string id;

            public GoalIDMsg(JSONNode msg)
            {
                time = new TimeMsg(msg["stamp"]);
                id = msg["id"].ToString();
            }

            public GoalIDMsg(TimeMsg _time, string _id)
            {
                time = _time;
                id = _id;
            }

            public static string GetMessageType()
            {
                return "actionlib_msgs/GoalID";
            }

            public override string ToString()
            {
                return "actionlib_msgs/GoalID [ stamp: " + time.ToString() + "id: " + id + "}";
            }

            public override string ToYAMLString()
            {
                return "{\"stamp\": " + time.ToYAMLString() + ", \"id\": " + id + "}";
            }
        }
    }
}