//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\winhttp.dll
// Interface ID: 3473dd4d-2e88-4006-9cba-22570909dd10
// Interface Version: 5.1



namespace rpc_3473dd4d_2e88_4006_9cba_22570909dd10_5_1
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
        }
        public void Write_2(Struct_2 p0)
        {
            WriteStruct<Struct_2>(p0);
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
        public Struct_1 Read_1()
        {
            return ReadStruct<Struct_1>();
        }
        public Struct_2 Read_2()
        {
            return ReadStruct<Struct_2>();
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
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<int>(Member10, new System.Action<int>(m.WriteInt32));
            m.WriteInt32(Member18);
            m.WriteInt32(Member1C);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member10 = u.ReadEmbeddedPointer<int>(new System.Func<int>(u.ReadInt32), false);
            Member18 = u.ReadInt32();
            Member1C = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<int> Member10;
        public int Member18;
        public int Member1C;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(int Member0, int Member4, string Member8, System.Nullable<int> Member10, int Member18, int Member1C)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member18 = Member18;
            this.Member1C = Member1C;
        }
    }
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteInt32(Member8);
            m.WriteInt32(MemberC);
            m.WriteInt32(Member10);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadInt32();
            MemberC = u.ReadInt32();
            Member10 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public int Member8;
        public int MemberC;
        public int Member10;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(int Member0, int Member4, int Member8, int MemberC, int Member10)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.MemberC = MemberC;
            this.Member10 = Member10;
        }
    }
    public struct Struct_2 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member10, new System.Action<string>(m.WriteTerminatedString));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member10 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member10;
        public static Struct_2 CreateDefault()
        {
            return new Struct_2();
        }
        public Struct_2(int Member0, string Member8, string Member10)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("3473dd4d-2e88-4006-9cba-22570909dd10", 5, 1)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        // async
        public int GetProxyForUrl(string p0, Struct_0 p1, Struct_1 p2, out Struct_2 p3, out int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"));
            m.Write_0(p1);
            m.Write_1(p2);
            _Unmarshal_Helper u = SendReceive(0, m);
            p3 = u.Read_2();
            p4 = u.ReadInt32();
            return u.ReadInt32();
        }
    }
    #endregion
}

