//Template auto generator:[AutoGenPt] v1.0
//Creation time:2021/6/30 11:58:47
using System;
using System.Collections;
using System.Collections.Generic;
namespace Lenovo.XR.Development.Net.Pt
{
public class PtInt32List
{
    public byte __tag__ { get;private set;}

	public List<int> Elements{ get;private set;}
	   
    public PtInt32List SetElements(List<int> value){Elements=value; __tag__|=1; return this;}
	
    public bool HasElements(){return (__tag__&1)==1;}
	
    public static byte[] Write(PtInt32List data)
    {
        using(ByteBuffer buffer = new ByteBuffer())
        {
            buffer.WriteByte(data.__tag__);
			if(data.HasElements())buffer.WriteCollection(data.Elements,element=>buffer.WriteInt32(element));
			
            return buffer.Getbuffer();
        }
    }

    public static PtInt32List Read(byte[] bytes)
    {
        using(ByteBuffer buffer = new ByteBuffer(bytes))
        {
            PtInt32List data = new PtInt32List();
            data.__tag__ = buffer.ReadByte();
			if(data.HasElements())data.Elements = buffer.ReadCollection(()=>buffer.ReadInt32());
			
            return data;
        }       
    }
}
}