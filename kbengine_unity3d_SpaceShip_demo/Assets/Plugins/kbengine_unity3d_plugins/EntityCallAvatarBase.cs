/*
	Generated by KBEngine!
	Please do not modify this file!
	
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	// defined in */scripts/entity_defs/Avatar.def
	public class EntityBaseEntityCall_AvatarBase : EntityCall
	{

		public EntityBaseEntityCall_AvatarBase(Int32 eid, string ename) : base(eid, ename)
		{
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_BASE;
		}

		public void transAvatar()
		{
			Bundle pBundle = newCall("transAvatar", 0);
			if(pBundle == null)
				return;

			sendCall(null);
		}

	}

	public class EntityCellEntityCall_AvatarBase : EntityCall
	{

		public EntityCellEntityCall_AvatarBase(Int32 eid, string ename) : base(eid, ename)
		{
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_CELL;
		}

		public void jump()
		{
			Bundle pBundle = newCall("jump", 0);
			if(pBundle == null)
				return;

			sendCall(null);
		}

		public void relive(Byte arg1)
		{
			Bundle pBundle = newCall("relive", 0);
			if(pBundle == null)
				return;

			bundle.writeUint8(arg1);
			sendCall(null);
		}

		public void reqUseWeapon(Vector3 arg1, Vector3 arg2, Vector3 arg3, UInt32 arg4)
		{
			Bundle pBundle = newCall("reqUseWeapon", 0);
			if(pBundle == null)
				return;

			bundle.writeVector3(arg1);
			bundle.writeVector3(arg2);
			bundle.writeVector3(arg3);
			bundle.writeUint32(arg4);
			sendCall(null);
		}

		public void setCruiseSpeed(UInt16 arg1)
		{
			Bundle pBundle = newCall("setCruiseSpeed", 0);
			if(pBundle == null)
				return;

			bundle.writeUint16(arg1);
			sendCall(null);
		}

	}
	}
