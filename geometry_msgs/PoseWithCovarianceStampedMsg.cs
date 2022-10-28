using ROSBridgeLib.geometry_msgs;
using ROSBridgeLib.std_msgs;

using SimpleJSON;

namespace ROSBridgeLib
{
    namespace geometry_msgs {
        class PoseWithCovarianceStampedMsg : ROSBridgeMsg{
            private HeaderMsg header;
            private PoseWithCovarianceMsg pose;

            public PoseWithCovarianceStampedMsg(JSONNode msg)
            {
                header = new HeaderMsg(msg["header"]);
                pose = new PoseWithCovarianceMsg(msg["pose"]);
            }

            public PoseWithCovarianceStampedMsg(HeaderMsg _header, PoseWithCovarianceMsg _pose)
            {
                header = _header;
                pose = _pose;
            }

            public static string GetMessageType()
            {
                return "geometry_msgs/PoseWithCovarianceStamped";
            }

            public override string ToString()
            {
                return "geometry_msgs/PoseWithCovarianceStamped [header=" + header.ToString() + ", pose=" + pose.ToString() + "]";
            }

            public override string ToYAMLString()
            {
                return "{\"header\": " + header.ToYAMLString() + ", \"pose\": " + pose.ToYAMLString() + "}";
            }

            public PointMsg GetPosition()
            {
                return pose.GetPose().GetPosition();
            }
            public QuaternionMsg GetRotation()
            {
                return pose.GetPose().GetOrientation();
            }
        }
    }
}