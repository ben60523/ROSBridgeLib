using System.Collections;
using System.IO;
using System.Text;
using SimpleJSON;
using ROSBridgeLib.std_msgs;
using ROSBridgeLib.geometry_msgs;
using UnityEngine;

namespace ROSBridgeLib {
    namespace nav_msgs {
        public class MapMetaDataMsg: ROSBridgeMsg {
            private TimeMsg map_load_time;
            private float resolution;
            private int width;
            private int height;
            private PoseMsg origin;

            public MapMetaDataMsg(JSONNode msg) {
				map_load_time = new TimeMsg(msg["map_load_time"]);
                resolution = float.Parse(msg["resolution"]);
                width = int.Parse(msg["width"]);
                height = int.Parse(msg["height"]);
                origin = new PoseMsg(msg["origin"]);
			}
			
			public MapMetaDataMsg(TimeMsg time, float _resolution, int _width, int _height, PoseMsg pose) {
				map_load_time = time;
				resolution = _resolution;
				width = _width;
                height = _height;
                origin = pose;
			}

            public int GetWidth()
            {
                return width;
            }
            public int GetHeight()
            {
                return height;
            }
            public float GetResolution()
            {
                return resolution;
            }
            public PoseMsg GetPose()
            {
                return origin;
            }


			public static string GetMessageType() {
				return "nav_msgs/MapMetaData";
			}
			
			public override string ToString() {
				return "Map Meta Data [map_load_time=" + map_load_time + ",  resolution=" + resolution + ", size (" + width+ ", " + height + ")]";
			}
			
			public override string ToYAMLString() {
				return "{\"map_load_time\" : " + "\"" 
                        + map_load_time.ToYAMLString() 
                        + "\", \"resolution\" : \"" 
                        + resolution  
                        + "\", \"width\" : " + width 
                        + "\", \"height\" : " + height
                        + "\", \"origin\" : " + origin.ToYAMLString()
                        + "}";
			}

        }
    }
}