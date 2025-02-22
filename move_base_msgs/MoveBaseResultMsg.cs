using ROSBridgeLib.std_msgs;
using ROSBridgeLib.geometry_msgs;
using SimpleJSON;

namespace ROSBridgeLib
{
    namespace move_base_msgs
    {
        public class MoveBaseResultMsg : ROSBridgeMsg
        {
            private string res;
            public MoveBaseResultMsg(JSONNode msg)
            {
                res = msg.ToString();
            }

            public MoveBaseResultMsg(string _res)
            {
                res = _res;
            }

            public static string GetMessageType()
            {
                return "move_base_msgs/MoveBaseResult";
            }

            public override string ToString()
            {
                return "move_base_msgs/MoveBaseResult [" + res + "]";
            }

            public override string ToYAMLString()
            {
                return "{" + res + "}";
            }

            public string GetResult()
            {
                return res;
            }
        }
    }
}