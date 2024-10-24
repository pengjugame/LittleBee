//Template auto generator:[AutoGenPt] v1.0
//Creation time:2021/6/30 11:58:47
using System;
using System.Collections;
using System.Collections.Generic;
namespace Lenovo.XR.Development.Net.Pt
{
public class PtEntity
{
    public byte __tag__ { get;private set;}

	public uint EntityId{ get;private set;}
	public uint UserId{ get;private set;}
	public byte TeamId{ get;private set;}
	   
    public PtEntity SetEntityId(uint value){EntityId=value; __tag__|=1; return this;}
	public PtEntity SetUserId(uint value){UserId=value; __tag__|=2; return this;}
	public PtEntity SetTeamId(byte value){TeamId=value; __tag__|=4; return this;}
	
    public bool HasEntityId(){return (__tag__&1)==1;}
	public bool HasUserId(){return (__tag__&2)==2;}
	public bool HasTeamId(){return (__tag__&4)==4;}
	
    public static byte[] Write(PtEntity data)
    {
        using(ByteBuffer buffer = new ByteBuffer())
        {
            buffer.WriteByte(data.__tag__);
			if(data.HasEntityId())buffer.WriteUInt32(data.EntityId);
			if(data.HasUserId())buffer.WriteUInt32(data.UserId);
			if(data.HasTeamId())buffer.WriteByte(data.TeamId);
			
            return buffer.Getbuffer();
        }
    }

    public static PtEntity Read(byte[] bytes)
    {
        using(ByteBuffer buffer = new ByteBuffer(bytes))
        {
            PtEntity data = new PtEntity();
            data.__tag__ = buffer.ReadByte();
			if(data.HasEntityId())data.EntityId = buffer.ReadUInt32();
			if(data.HasUserId())data.UserId = buffer.ReadUInt32();
			if(data.HasTeamId())data.TeamId = buffer.ReadByte();
			
            return data;
        }       
    }
}
}
