using System.Collections.Generic;
using ROSBridgeLib.std_msgs;
using SimpleJSON;

namespace ROSBridgeLib
{
    namespace sensor_msgs
    {
        public class LaserScanMsg : ROSBridgeMsg
        {
            private HeaderMsg header;
            private float angle_min, angle_max, angle_increment, time_increment, scan_time, range_min, range_max;
            private List<float> ranges = new List<float>();
            private List<float> intensities = new List<float>();

            public LaserScanMsg(JSONNode msg)
            {
                header = new HeaderMsg(msg["header"]);
                angle_min = float.Parse(msg["angle_min"]);
                angle_max = float.Parse(msg["angle_max"]);
                angle_increment = float.Parse(msg["angle_increment"]);
                time_increment = float.Parse(msg["time_increment"]);
                scan_time = float.Parse(msg["scan_time"]);
                range_min = float.Parse(msg["range_min"]);
                range_max = float.Parse(msg["range_max"]);

                for (int i = 0; i < msg["ranges"].Count; i++)
                {   
                    float value = msg["ranges"][i].AsFloat;
                    if (value == 0)
                    {
                        value = range_max;
                    }
                    ranges.Add(value);
                    intensities.Add(msg["intensities"][i].AsFloat);
                }
            }

            public static string GetMessageType()
            {
                return "sensor_msgs/LaserScan";
            }

            public List<float> GetRanges()
            {
                return ranges;
            }

            public float GetAngleMin()
            {
                return angle_min;
            }

            public float GetAngleMax()
            {
                return angle_max;
            }

            public float GetAngleIncrement()
            {
                return angle_increment;
            }

            /**
            public LaserScanMsg()
            {

            }
            */
        }
    }
}