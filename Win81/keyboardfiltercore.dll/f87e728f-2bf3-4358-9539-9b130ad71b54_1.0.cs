//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\KeyboardFilterCore.dll
// Interface ID: f87e728f-2bf3-4358-9539-9b130ad71b54
// Interface Version: 1.0



namespace rpc_f87e728f_2bf3_4358_9539_9b130ad71b54_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(Struct_0[] p0, long p1, long p2)
        {
            WriteConformantVaryingStructArray<Struct_0>(p0, p1, p2);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
        public Struct_0 Read_0()
        {
            return ReadStruct<Struct_0>();
        }
        public Struct_0[] Read_1()
        {
            return ReadConformantVaryingStructArray<Struct_0>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEnum16(Member0);
            m.WriteInt16(Member4);
            m.WriteInt32(Member8);
            m.WriteInt32(MemberC);
            m.WriteInt32(Member10);
            m.WriteInt32(Member14);
            m.WriteInt32(Member18);
            m.WriteInt32(Member1C);
            m.WriteInt32(Member20);
            m.WriteInt32(Member24);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEnum16();
            Member4 = u.ReadInt16();
            Member8 = u.ReadInt32();
            MemberC = u.ReadInt32();
            Member10 = u.ReadInt32();
            Member14 = u.ReadInt32();
            Member18 = u.ReadInt32();
            Member1C = u.ReadInt32();
            Member20 = u.ReadInt32();
            Member24 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0;
        public short Member4;
        public int Member8;
        public int MemberC;
        public int Member10;
        public int Member14;
        public int Member18;
        public int Member1C;
        public int Member20;
        public int Member24;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0, short Member4, int Member8, int MemberC, int Member10, int Member14, int Member18, int Member1C, int Member20, int Member24)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.MemberC = MemberC;
            this.Member10 = Member10;
            this.Member14 = Member14;
            this.Member18 = Member18;
            this.Member1C = Member1C;
            this.Member20 = Member20;
            this.Member24 = Member24;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("f87e728f-2bf3-4358-9539-9b130ad71b54", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int KBFKEYToScancode(long p0, Struct_0 p1, out Struct_0[] p2, int p3, out int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt64(p0);
            m.Write_0(p1);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(0, m);
            p2 = u.Read_1();
            p4 = u.ReadInt32();
            return u.ReadInt32();
        }
    }
    #endregion
}

