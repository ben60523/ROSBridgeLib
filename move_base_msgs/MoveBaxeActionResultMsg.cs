using ROSBridgeLib.actionlib_msgs;
using ROSBridgeLib.std_msgs;
using SimpleJSON;

namespace ROSBridgeLib
{
    namespace move_base_msgs
    {
        class MoveBaseActionResultMsg : ROSBridgeMsg
        {
            private HeaderMsg _header;
            private GoalStatusMsg _status;
            private MoveBaseResultMsg _result;

            public static string GetMessageType()
            {
                return "move_base_msgs/MoveBaseActionResult";
            }

            public MoveBaseActionResultMsg(JSONNode msg)
            {
                _header = new HeaderMsg(msg["header"]);
                _status = new GoalStatusMsg(msg["status"]);
                _result = new MoveBaseResultMsg(msg["result"]);
            }
            public int GetResultStatus()
            {
                return (int)_status.GetStatus();
            }
            public string GetResultStatusDescription()
            {
                return _status.GetStatus().ToString();
            }

            public StatusType GetResultStatusEnum()
            {
                return _status.GetStatus();
            }
        }
    }
}