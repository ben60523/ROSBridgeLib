using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SimpleJSON;
using ROSBridgeLib.std_msgs;
using ROSBridgeLib.geometry_msgs;
using UnityEngine;

namespace ROSBridgeLib
{
    namespace nav_msgs
    {
        public class OccupancyGridMsg : ROSBridgeMsg
        {
            private HeaderMsg header;
            private MapMetaDataMsg info;
            // private sbyte[] data;
            // private string data;
            private List<int> data = new List<int>();
            public OccupancyGridMsg(JSONNode msg)
            {
                header = new HeaderMsg(msg["header"]);
                info = new MapMetaDataMsg(msg["info"]);
                // data = System.Convert.FromBase64String(msg["data"]);
                for (int i = 0; i < msg["data"].Count; i++)
                {
                    data.Add(msg["data"][i].AsInt);
                }
            }

            public OccupancyGridMsg(HeaderMsg _header, MapMetaDataMsg _info, List<int> _data)
            {
                header = _header;
                info = _info;
                data = _data;
            }

            public List<int> GetData()
            {
                return data;
            }
            public int GetWidth()
            {
                return info.GetWidth();
            }
            public int GetHeight()
            {
                return info.GetHeight();
            }
            public float GetResolution()
            {
                return info.GetResolution();
            }

            public PoseMsg GetOriginPose()
            {
                return info.GetPose();
            }

            public static string GetMessageType()
            {
                return "nav_msgs/OccupancyGrid";
            }

            public override string ToString()
            {
                return "Map [Header=" + header.ToString() + ",  metadata=" + info.ToString() + ", " + "data=" + data.ToString() + "]";
            }

            public override string ToYAMLString()
            {
                return "{\"header\" : " + "\""
                        + header.ToYAMLString()
                        + "\", \"info\" : \""
                        + info.ToYAMLString()
                        + "\", \"data\" : "
                        + data
                        + "}";
            }

        }
    }
}