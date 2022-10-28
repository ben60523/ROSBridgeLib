using ROSBridgeLib.actionlib_msgs;
using ROSBridgeLib.std_msgs;
using SimpleJSON;

namespace ROSBridgeLib
{
    namespace move_base_msgs
    {
        class MoveBaseActionResultMsg : ROSBridgeMsg
        {
            private HeaderMsg header;
            private GoalStatusMsg status;
            private MoveBaseResultMsg result;

            public MoveBaseActionResultMsg(JSONNode msg)
            {
                header = new HeaderMsg(msg["header"]);
                status = new GoalStatusMsg(msg["status"]);
                result = new MoveBaseResultMsg(msg["result"]);
            }

            public MoveBaseActionResultMsg(HeaderMsg _header, GoalStatusMsg _status, MoveBaseResultMsg _result)
            {
                header = _header;
                status = _status;
                result = _result;
            }

            public static string GetMessageType()
            {
                return "move_base_msgs/MoveBaseActionResult";
            }

            public override string ToString()
            {
                return "move_base_msgs/MoveBaseActionResult [header=" + header.ToString() + 
                                                          ", status=" + status.ToString() + 
                                                          ", result=" + result.ToString() + "]";
            }

            public override string ToYAMLString()
            {
                return "{\"header\": " + header.ToYAMLString() + 
                       ", \"status\": " + status.ToYAMLString() + 
                       ", \"result\": " + result.ToYAMLString() + "}";
            }

            public int GetResultStatus()
            {
                return (int)status.GetStatus();
            }
            public string GetResultStatusDescription()
            {
                return status.GetStatus().ToString();
            }

            public StatusType GetResultStatusEnum()
            {
                return status.GetStatus();
            }
        }
    }
}