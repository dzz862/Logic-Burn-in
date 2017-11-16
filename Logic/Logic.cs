using System;
using System.Collections;
using System.Collections.Generic;

namespace Logic
{
    public class C_Transform
    {
        private byte input_pin_map = 0;
        private byte output_pin_map = 0;
        private ushort addrpoint = 0;
        List<bool> inivalue = new List<bool>();

        public double Calc_Time(double time)
        {
            return (time * 50);

        }

        public List<byte> GetResult(List<List<C_Data>> channels_data, double cycle_time)
        {
            List<byte> result = new List<byte>();
            List<byte> body = new List<byte>();
            List<byte> head = new List<byte>();
            List<ushort> cfg = new List<ushort>();
            List<ushort> addr = new List<ushort>();

            head.Add(129);
            addrpoint += 1;                             //head
            addrpoint += 2;                             //pin_map
            addrpoint += 4;                              //time
            addrpoint += (ushort)(4 * channels_data.Count);

            channels_data.Sort(delegate (List<C_Data> data2, List<C_Data> data1)
            {
                int a = (data1[0].type == E_Data_Type.OUTPUT_DIGITAL || data1[0].type == E_Data_Type.OUTPUT_IIC) ? 1 : 0;
                int b = (data2[0].type == E_Data_Type.OUTPUT_DIGITAL || data2[0].type == E_Data_Type.OUTPUT_IIC) ? 1 : 0;

                int r = a.CompareTo(b);
                if (r != 0)
                {
                    return r;
                }
                else
                {
                    int s = data2[0].channel.CompareTo(data1[0].channel);
                    if (s != 0)
                    {
                        return s;
                    }
                    else
                    {
                        throw new InvalidOperationException("Channel is duplicated");
                    }
                }
            });

            int c = 0;
            int o = 0;
            int i = 0;

            while (c < channels_data.Count)
            {
                ushort output_pin_cfg = 0;
                ushort input_pin_cfg = 0;
                switch (channels_data[c][0].type)
                {
                    case E_Data_Type.OUTPUT_DIGITAL:

                        output_pin_map = (byte)(output_pin_map | (0x01 << o));
                        output_pin_cfg |= (ushort)(((C_ODData)(channels_data[c][0])).value ? 0x0001 : 0x0000);  //initial data
                        if (channels_data[c].Count * 4 < 16383)
                        {
                            output_pin_cfg |= (ushort)((channels_data[c].Count * 4) << 2);  //data count
                            cfg.Add(output_pin_cfg);
                            addr.Add(addrpoint);
                            addrpoint += (ushort)(4 * channels_data[c].Count);
                        }
                        else
                        {
                            throw new IndexOutOfRangeException();
                        }

                        o++;
                        break;

                    //case E_Data_Type.OUTPUT_IIC:

                    //    output_pin_map = (byte)(output_pin_map | (0x01 << i));
                    //    output_pin_cfg = 0x0000;

                    //    output_pin_cfg |= 0x0000;
                    //    if (channels_data[i].Count < 16383)
                    //    {
                    //        output_pin_cfg |= (ushort)channels_data[i].Count;
                    //        cfg.Add(output_pin_cfg);
                    //        addr.Add(addrpoint);
                    //        addrpoint += (ushort)(4 * channels_data[i].Count);
                    //    }
                    //    else
                    //    {
                    //        throw new IndexOutOfRangeException();
                    //    }
                    //    o++;
                    //    break;

                    case E_Data_Type.INPUT_DIGITAL:

                        input_pin_map = (byte)(input_pin_map | (0x01 << i));
                        //input_pin_cfg |= (ushort)(((C_IDData)(channels_data[i][0])).value ? 0x4000 : 0x0000);   //inital data
                        input_pin_cfg |= 0x0002;
                        if (channels_data[c].Count < 16383)
                        {
                            input_pin_cfg |= (ushort)((channels_data[c].Count * 8) << 2); ;
                            cfg.Add(input_pin_cfg);
                            addr.Add(addrpoint);
                            addrpoint += (ushort)(4 * channels_data[c].Count);
                        }
                        else
                        {
                            throw new IndexOutOfRangeException("Data is too much, please reduce data");
                        }
                        i++;
                        break;

                        //    case E_Data_Type.INPUT_ANALOG:

                        //        input_pin_map = (byte)(input_pin_map | (0x01 << i));
                        //        input_pin_cfg = 0x0000;

                        //        input_pin_cfg |= 0x4000;
                        //        if (channels_data[i].Count < 16383)
                        //        {
                        //            input_pin_cfg |= (ushort)channels_data[i].Count;
                        //            cfg.Add(input_pin_cfg);
                        //            addr.Add(addrpoint);
                        //            addrpoint += (ushort)(4 * channels_data[i].Count);
                        //        }
                        //        else
                        //        {
                        //            throw new IndexOutOfRangeException();
                        //        }
                        //        i++;
                        //        break;

                        //    case E_Data_Type.INPUT_IIC:

                        //        input_pin_map = (byte)(input_pin_map | (0x01 << i));
                        //        input_pin_cfg = 0x0000;

                        //        input_pin_cfg |= 0x0000;
                        //        if (channels_data[i].Count < 16383)
                        //        {
                        //            input_pin_cfg |= (ushort)channels_data[i].Count;
                        //            cfg.Add(input_pin_cfg);
                        //            addr.Add(addrpoint);
                        //            addrpoint += (ushort)(4 * channels_data[i].Count);
                        //        }
                        //        else
                        //        {
                        //            throw new IndexOutOfRangeException();
                        //        }
                        //        i++;
                        //        break;
                }

                for (int d = 0; d < channels_data[c].Count; d++)
                {
                    body.AddRange(channels_data[c][d].Convert());
                }

                c++;
            }


            head.Add(output_pin_map);
            head.Add(input_pin_map);
            cycle_time = Calc_Time(cycle_time); // (cycle_time * 100 - 58) ;
            head.Add((byte)((int)cycle_time >> 24));
            head.Add((byte)(((int)cycle_time & 0xFF0000) >> 16));
            head.Add((byte)(((int)cycle_time & 0xFF00) >> 8));
            head.Add((byte)((int)cycle_time & 0xFF));

            for (int cf = 0; cf < cfg.Count; cf++)
            {
                head.Add((byte)(cfg[cf] >> 8));
                head.Add((byte)(cfg[cf] & 0x00FF));
                head.Add((byte)(addr[cf] >> 8));
                head.Add((byte)(addr[cf] & 0x00FF));
            }

            result.AddRange(head);
            result.AddRange(body);

            return result;
        }
    }

    public enum E_Data_Type
    {
        OUTPUT_DIGITAL = 0,
        OUTPUT_IIC,
        INPUT_DIGITAL,
        INPUT_ANALOG,
        INPUT_IIC,
    };

    public abstract class C_Data
    {
        public int channel { get; set; }
        public abstract E_Data_Type type { get; }
        public C_Data(int channel)
        {
            this.channel = channel;
        }
        public abstract List<byte> Convert();
        public double Calc_Time(double time)
        {
            return ((time * 50));
        }
    }


    public class C_ODData : C_Data
    {
        public Double time { get; set; }
        public bool value { get; set; }
        public override E_Data_Type type
        {
            get
            {
                return E_Data_Type.OUTPUT_DIGITAL;
            }
        }

        public C_ODData(int channel) : base(channel)
        {
            this.channel = channel;
        }
        public override List<byte> Convert()
        {
            List<byte> result = new List<byte>();

            UInt32 temp = (UInt32)Calc_Time(time);// * 100) - 58);
            result.Add((byte)(temp >> 24));
            result.Add((byte)((temp & 0xFF0000) >> 16));
            result.Add((byte)((temp & 0xFF00) >> 8));
            result.Add((byte)(temp & 0xFF));

            return result;
        }
    }
    public abstract class C_IICData : C_Data
    {
        public C_IICData(int channel) : base(channel)
        {
            this.channel = channel;
        }
        public int time { get; set; }
        public byte slave_addr { get; set; }
        public byte reg_addr_H { get; set; }
        public byte reg_addr_L { get; set; }
        public byte data { get; set; }
    }

    public class C_OIICData : C_IICData
    {
        public C_OIICData(int channel) : base(channel)
        {
            this.channel = channel;
        }

        public override E_Data_Type type
        {
            get
            {
                return E_Data_Type.OUTPUT_IIC;
            }
        }

        public override List<byte> Convert()
        {
            List<byte> result = new List<byte>();

            UInt32 temp = (UInt32)(time / 1000 - 1);
            result.Add((byte)(temp >> 24));
            result.Add((byte)((temp & 0xFF0000) >> 16));
            result.Add((byte)((temp & 0xFF00) >> 8));
            result.Add((byte)(temp & 0xFF));
            result.Add(slave_addr);
            result.Add(reg_addr_H);
            result.Add(reg_addr_L);
            result.Add(data);

            return result;
        }
    };
    public class C_IIICData : C_IICData
    {
        public C_IIICData(int channel) : base(channel)
        {
            this.channel = channel;
        }

        public override E_Data_Type type
        {
            get
            {
                return E_Data_Type.INPUT_IIC;
            }
        }

        public override List<byte> Convert()
        {
            List<byte> result = new List<byte>();

            UInt32 temp = (UInt32)(time / 1000 - 1);
            result.Add((byte)(temp >> 24));
            result.Add((byte)((temp & 0xFF0000) >> 16));
            result.Add((byte)((temp & 0xFF00) >> 8));
            result.Add((byte)(temp & 0xFF));
            result.Add(slave_addr);
            result.Add(reg_addr_H);
            result.Add(reg_addr_L);
            result.Add(data);

            return result;
        }
    };

    public class C_IDData : C_Data
    {
        public Double time_min { get; set; }
        public Double time_max { get; set; }
        public bool value { get; set; }
        public C_IDData(int channel) : base(channel)
        {
            this.channel = channel;
        }

        public override E_Data_Type type
        {
            get
            {
                return E_Data_Type.INPUT_DIGITAL;
            }
        }

        public override List<byte> Convert()
        {
            List<byte> result = new List<byte>();

            UInt32 temp = (UInt32)Calc_Time(time_min);// * 100) - 58);
            result.Add((byte)(temp >> 24));
            result.Add((byte)((temp & 0xFF0000) >> 16));
            result.Add((byte)((temp & 0xFF00) >> 8));
            result.Add((byte)(temp & 0xFF));


            temp = (UInt32)Calc_Time(time_max);// * 100) - 58);
            result.Add((byte)(temp >> 24));
            result.Add((byte)((temp & 0xFF0000) >> 16));
            result.Add((byte)((temp & 0xFF00) >> 8));
            result.Add((byte)(temp & 0xFF));

            return result;
        }
    }

    public class C_IAData : C_Data
    {
        public C_IAData(int channel) : base(channel)
        {
            this.channel = channel;
        }
        public int time { get; set; }
        public int value_min { get; set; }
        public int value_max { get; set; }

        public override E_Data_Type type
        {
            get
            {
                return E_Data_Type.INPUT_ANALOG;
            }
        }

        public override List<byte> Convert()
        {
            List<byte> result = new List<byte>();
            UInt16 temp = 0;

            temp = (UInt16)(time / 1000 - 1);
            result.Add((byte)(temp >> 8));
            result.Add((byte)(temp & 0xFF));

            result.Add((byte)(value_min));
            result.Add((byte)(value_max));

            return result;
        }
    }
}
