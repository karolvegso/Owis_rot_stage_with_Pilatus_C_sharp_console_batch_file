/*
*
* ps10func.cs
* created:      09.07.2008  alex
* last change:  29.09.2016  alex
*
*/


using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;


namespace ps10func
{
    public unsafe class CPS10Win
    {
       const string PS10DLL = "ps10.dll";
       const string PS10uDLL = "ps10u.dll";

       // System
		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
			public static extern Int32 PS10_Connect(Int32 Index, Int32 Int, Int32 p1, Int32 p2, Int32 p3, Int32 p4, Int32 p5, Int32 p6);
        #else
            [DllImport(PS10DLL)] // default - CharSet.Ansi
            public static extern Int32 PS10_Connect(Int32 Index, Int32 Int, Int32 p1, Int32 p2, Int32 p3, Int32 p4, Int32 p5, Int32 p6);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SimpleConnect(Int32 Index, String strSerNum);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SimpleConnect(Int32 Index, String strSerNum);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_Disconnect(Int32 Index);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_Disconnect(Int32 Index);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetCanOpenSlave(Int32 SlaveDevNr, Int32 nBusAdd);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetCanOpenSlave(Int32 SlaveDevNr, Int32 nBusAdd);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetCanOpenSlave(Int32 SlaveDevNr);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetCanOpenSlave(Int32 SlaveDevNr);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetSlaves(Int32 Index);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetSlaves(Int32 Index);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetConnectInfo(Int32 Index, StringBuilder strBuffer, Int32 Len, Int32 nMode);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetConnectInfo(Int32 Index, StringBuilder strBuffer, Int32 Len, Int32 nMode);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetMessage(Int32 Index, StringBuilder strBuffer, Int32 Len);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetMessage(Int32 Index, StringBuilder strBuffer, Int32 Len);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetTerminal(Int32 Index);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetTerminal(Int32 Index);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetTerminal(Int32 Index, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetTerminal(Int32 Index, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetBoardVersion(Int32 Index, StringBuilder strBuffer, Int32 Len);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetBoardVersion(Int32 Index, StringBuilder strBuffer, Int32 Len);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetSerNumber(Int32 Index, StringBuilder strBuffer, Int32 Len);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetSerNumber(Int32 Index, StringBuilder strBuffer, Int32 Len);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetError(Int32 Index);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetError(Int32 Index);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_CheckMem(Int32 Index);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_CheckMem(Int32 Index);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_ResetBoard(Int32 Index);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_ResetBoard(Int32 Index);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_ClearError(Int32 Index);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_ClearError(Int32 Index);
        #endif

        // Operate
		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_MotorInit(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_MotorInit(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_MotorOn(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_MotorOn(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_MotorOff(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_MotorOff(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetTargetMode(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetTargetMode(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetTargetMode(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetTargetMode(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetPosition(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetPosition(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetPosition(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetPosition(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_ResetCounter(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_ResetCounter(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetTarget(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetTarget(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetTarget(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetTarget(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GoTarget(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GoTarget(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GoRef(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GoRef(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_FreeSwitch(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_FreeSwitch(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_Stop(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_Stop(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GoVel(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GoVel(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_StopVel(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_StopVel(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetMotorType(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetMotorType(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetMotorType(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetMotorType(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetEncLines(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetEncLines(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetEncLines(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetEncLines(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetAxisMonitor(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetAxisMonitor(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetAxisMonitor(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetAxisMonitor(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetAxisState(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetAxisState(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetMoveState(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetMoveState(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetVelState(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetVelState(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetErrorState(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetErrorState(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetRefReady(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetRefReady(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetActF(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetActF(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetEncPos(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetEncPos(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetPosError(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetPosError(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetMaxPosError(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetMaxPosError(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetMaxPosError(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetMaxPosError(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetPosRange(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetPosRange(Int32 Index, Int32 nAxis);
        #endif

 	    // Adjustments
		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SaveAxisParams(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SaveAxisParams(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetAccel(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetAccel(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetAccel(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetAccel(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetRefDecel(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetRefDecel(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetRefDecel(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetRefDecel(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetPosF(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetPosF(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetPosF(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetPosF(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetF(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetF(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetF(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetF(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetSlowRefF(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetSlowRefF(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetSlowRefF(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetSlowRefF(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetFastRefF(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetFastRefF(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetFastRefF(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetFastRefF(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetFreeF(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetFreeF(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetFreeF(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetFreeF(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetMicrostepMode(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetMicrostepMode(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetMicrostepMode(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetMicrostepMode(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetDriveCurrent(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetDriveCurrent(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetDriveCurrent(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetDriveCurrent(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetHoldCurrent(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetHoldCurrent(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetHoldCurrent(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetHoldCurrent(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetPhaseInitTime(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetPhaseInitTime(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetPhaseInitTime(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetPhaseInitTime(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetPhasePwmFreq(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetPhasePwmFreq(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetPhasePwmFreq(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetPhasePwmFreq(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetCurrentLevel(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetCurrentLevel(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetCurrentLevel(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetCurrentLevel(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetServoLoopMax(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetServoLoopMax(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetServoLoopMax(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetServoLoopMax(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

	    // Software/hardware regulator
		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetSampleTime(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetSampleTime(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
             public static extern Int32 PS10_SetSampleTime(Int32 Index, Int32 nAxis, Int32 nValue);
       #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetSampleTime(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetKP(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetKP(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetKP(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetKP(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetKI(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetKI(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetKI(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetKI(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetKD(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetKD(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetKD(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetKD(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetDTime(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetDTime(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetDTime(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetDTime(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetILimit(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetILimit(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetILimit(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetILimit(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

        // Hardware/software switches
		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetLimitSwitch(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetLimitSwitch(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetLimitSwitch(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetLimitSwitch(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetLimitSwitchMode(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetLimitSwitchMode(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetLimitSwitchMode(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetLimitSwitchMode(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetRefSwitch(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetRefSwitch(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetRefSwitch(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetRefSwitch(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetRefSwitchMode(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetRefSwitchMode(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetRefSwitchMode(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetRefSwitchMode(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetSwitchState(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetSwitchState(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetSwitchHyst(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetSwitchHyst(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetLimitControl(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetLimitControl(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetLimitControl(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetLimitControl(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetLimitMin(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetLimitMin(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetLimitMin(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetLimitMin(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetLimitMax(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetLimitMax(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetLimitMax(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetLimitMax(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetLimitState(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetLimitState(Int32 Index, Int32 nAxis);
        #endif

	    // Joystick
		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_JoystickOn(Int32 Index);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_JoystickOn(Int32 Index);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_JoystickOff(Int32 Index);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_JoystickOff(Int32 Index);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetJoyF(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetJoyF(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetJoyF(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetJoyF(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetJoyZone(Int32 Index);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetJoyZone(Int32 Index);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetJoyZone(Int32 Index, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetJoyZone(Int32 Index, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetJoyZero(Int32 Index);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetJoyZero(Int32 Index);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetJoyZero(Int32 Index, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetJoyZero(Int32 Index, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetJoyButton(Int32 Index);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetJoyButton(Int32 Index);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetJoyButton(Int32 Index, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetJoyButton(Int32 Index, Int32 nValue);
        #endif

	    // Analog & digital I/O
		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetDigitalInput(Int32 Index, Int32 nPin);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetDigitalInput(Int32 Index, Int32 nPin);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetDigitalOutput(Int32 Index, Int32 nPin);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetDigitalOutput(Int32 Index, Int32 nPin);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetDigitalOutput(Int32 Index, Int32 nPin, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetDigitalOutput(Int32 Index, Int32 nPin, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetAnalogInput(Int32 Index, Int32 nInput);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetAnalogInput(Int32 Index, Int32 nInput);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetPwmOutput(Int32 Index, Int32 nOutput);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetPwmOutput(Int32 Index, Int32 nOutput);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetPwmOutput(Int32 Index, Int32 nOutput, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetPwmOutput(Int32 Index, Int32 nOutput, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetOutputMode(Int32 Index);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetOutputMode(Int32 Index);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetOutputMode(Int32 Index, Int32 nMode);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetOutputMode(Int32 Index, Int32 nMode);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetPwmBrake(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetPwmBrake(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetPwmBrake(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetPwmBrake(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetPwmBrakeValue1(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetPwmBrakeValue1(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetPwmBrakeValue1(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetPwmBrakeValue1(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetPwmBrakeValue2(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetPwmBrakeValue2(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetPwmBrakeValue2(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetPwmBrakeValue2(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetPwmBrakeTime(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetPwmBrakeTime(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetPwmBrakeTime(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetPwmBrakeTime(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetPowerMode(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetPowerMode(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetPowerMode(Int32 Index, Int32 nAxis, Int32 nValue);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetPowerMode(Int32 Index, Int32 nAxis, Int32 nValue);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetPowerState(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetPowerState(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetEmergencyInput(Int32 Index);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetEmergencyInput(Int32 Index);
        #endif

	    // Extended functions
		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetStageAttributes(Int32 Index, Int32 nAxis, Double pitch, Int32 inc_rev, Double ratio);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetStageAttributes(Int32 Index, Int32 nAxis, Double pitch, Int32 inc_rev, Double ratio);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetCalcResol(Int32 Index, Int32 nAxis, Double cresol);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetCalcResol(Int32 Index, Int32 nAxis, Double cresol);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Double PS10_GetPositionEx(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Double PS10_GetPositionEx(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetPositionEx(Int32 Index, Int32 nAxis, Double dVal);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetPositionEx(Int32 Index, Int32 nAxis, Double dVal);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Double PS10_GetTargetEx(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Double PS10_GetTargetEx(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetTargetEx(Int32 Index, Int32 nAxis, Double dVal);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetTargetEx(Int32 Index, Int32 nAxis, Double dVal);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Double PS10_GetPosRangeEx(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Double PS10_GetPosRangeEx(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Double PS10_GetEncPosEx(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Double PS10_GetEncPosEx(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Double PS10_GetLimitMinEx(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Double PS10_GetLimitMinEx(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetLimitMinEx(Int32 Index, Int32 nAxis, Double dVal);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetLimitMinEx(Int32 Index, Int32 nAxis, Double dVal);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Double PS10_GetLimitMaxEx(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Double PS10_GetLimitMaxEx(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetLimitMaxEx(Int32 Index, Int32 nAxis, Double dVal);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetLimitMaxEx(Int32 Index, Int32 nAxis, Double dVal);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_MoveEx(Int32 Index, Int32 nAxis, Double dVal, Int32 nNoInc);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_MoveEx(Int32 Index, Int32 nAxis, Double dVal, Int32 nNoInc);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_MoveTriggerEx(Int32 Index, Int32 nAxis, Int32 nInput, Int32 nHigh);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_MoveTriggerEx(Int32 Index, Int32 nAxis, Int32 nInput, Int32 nHigh);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_MoveAnalogInputEx(Int32 Index, Int32 nAxis, Int32 nInput, Double dMaxVal, Int32 nNoInc);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_MoveAnalogInputEx(Int32 Index, Int32 nAxis, Int32 nInput, Double dMaxVal, Int32 nNoInc);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Double PS10_GetPosFEx(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Double PS10_GetPosFEx(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetPosFEx(Int32 Index, Int32 nAxis, Double dVal);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetPosFEx(Int32 Index, Int32 nAxis, Double dVal);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Double PS10_GetFEx(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Double PS10_GetFEx(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetFEx(Int32 Index, Int32 nAxis, Double dVal);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetFEx(Int32 Index, Int32 nAxis, Double dVal);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Double PS10_GetSlowRefFEx(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Double PS10_GetSlowRefFEx(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetSlowRefFEx(Int32 Index, Int32 nAxis, Double dVal);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetSlowRefFEx(Int32 Index, Int32 nAxis, Double dVal);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Double PS10_GetFastRefFEx(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Double PS10_GetFastRefFEx(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetFastRefFEx(Int32 Index, Int32 nAxis, Double dVal);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetFastRefFEx(Int32 Index, Int32 nAxis, Double dVal);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Double PS10_GetFreeFEx(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Double PS10_GetFreeFEx(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetFreeFEx(Int32 Index, Int32 nAxis, Double dVal);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetFreeFEx(Int32 Index, Int32 nAxis, Double dVal);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Double PS10_GetJoyFEx(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Double PS10_GetJoyFEx(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetJoyFEx(Int32 Index, Int32 nAxis, Double dVal);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetJoyFEx(Int32 Index, Int32 nAxis, Double dVal);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Double PS10_GetActFEx(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Double PS10_GetActFEx(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Double PS10_GetAccelEx(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Double PS10_GetAccelEx(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetAccelEx(Int32 Index, Int32 nAxis, Double dVal);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetAccelEx(Int32 Index, Int32 nAxis, Double dVal);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Double PS10_GetRefDecelEx(Int32 Index, Int32 nAxis);
        #else
            [DllImport(PS10DLL)]
            public static extern Double PS10_GetRefDecelEx(Int32 Index, Int32 nAxis);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SetRefDecelEx(Int32 Index, Int32 nAxis, Double dVal);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SetRefDecelEx(Int32 Index, Int32 nAxis, Double dVal);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetOWISidData(Int32 Index, Int32 nAxis, Int32 nParamNum, StringBuilder strBuffer, Int32 Len);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetOWISidData(Int32 Index, Int32 nAxis, Int32 nParamNum, StringBuilder strBuffer, Int32 Len);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_LoadTextFile(Int32 Index, Int32 nAxis, String strFile);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_LoadTextFile(Int32 Index, Int32 nAxis, String strFile);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_SaveTextFile(Int32 Index, Int32 nAxis, String strFile);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_SaveTextFile(Int32 Index, Int32 nAxis, String strFile);
        #endif

	    // Communication
		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_LogFile(Int32 Index, Int32 nOpen, String strFile, Int32 nAppend, Int32 nMode);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_LogFile(Int32 Index, Int32 nOpen, String strFile, Int32 nAppend, Int32 nMode);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_CmdAns(Int32 Index, String strCmd, StringBuilder strAns, Int32 Len, Int32 nRequest);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_CmdAns(Int32 Index, String strCmd, StringBuilder strAns, Int32 Len, Int32 nRequest);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_CmdAnsEx(Int32 Index, String strCmd, StringBuilder strAns, Int32 Len, Int32 nRequest, Int32 nBreak);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_CmdAnsEx(Int32 Index, String strCmd, StringBuilder strAns, Int32 Len, Int32 nRequest, Int32 nBreak);
        #endif

		#if (_UNICODE)
            [DllImport(PS10uDLL, CharSet = CharSet.Unicode)]
            public static extern Int32 PS10_GetReadError(Int32 Index);
        #else
            [DllImport(PS10DLL)]
            public static extern Int32 PS10_GetReadError(Int32 Index);
        #endif


        // class variables
        Int32 m_nController;	// Controller number 1...10
        Boolean m_bConnected;	// Is there an active connection?
        Int32 m_nLastError;	    // Last return code from a PS10 library function


	    // Contructors
        public CPS10Win()
        {
	        m_nController = 0;
	        m_bConnected = false;
	        m_nLastError = 0;
        }

        public CPS10Win(Int32 nController, Int32 nInt, Int32 nComPort) // nInt=0 - virtual serial interface (USB)
        {
	        m_nController = nController;
	        m_bConnected = false;
	        m_nLastError = 0;

	        Connect(nController, nInt, nComPort, 9600, 0,0,0,0);
        }

        ~CPS10Win()
        {
	        if(m_bConnected) Disconnect();
        }

        // Member *********************************************************
        public Boolean IsConnected() {return m_bConnected;}
	    public Int32 GetIndex() {return m_nController;}
	    public Int32 GetLastError() {return m_nLastError;}

        // Operations *****************************************************
        // System
        public Int32 Connect(Int32 nController, Int32 nInt, Int32 p1, Int32 p2, Int32 p3, Int32 p4, Int32 p5, Int32 p6)
        {
	        if(m_bConnected) Disconnect();

            m_nLastError=PS10_Connect(
                nController,
                nInt,
                p1,
                p2,
                p3,
                p4,
                p5,
                p6);

	        if(m_nLastError == 0)
	        {
		        m_nController = nController;
		        m_bConnected = true;
	        }
	        else
		        m_bConnected = false;

	        return m_nLastError;
        }

        public Int32 SimpleConnect(Int32 nController, String strSerNum)
        {
	        if(m_bConnected) Disconnect();

            m_nLastError=PS10_SimpleConnect(
                nController,
                strSerNum);

	        if(m_nLastError == 0)
	        {
		        m_nController = nController;
		        m_bConnected = true;
	        }
	        else
		        m_bConnected = false;

	        return m_nLastError;
        }

        public Int32 Disconnect()
        {
            m_nLastError=PS10_Disconnect(m_nController);

	        if(m_nLastError == 0)
	        {
		        m_nController = 0;
		        m_bConnected = false;
	        }

	        return m_nLastError;
        }

        public Int32 SetCanOpenSlave(Int32 nSlaveDevNr, Int32 nBusAdd)
        {
            m_nLastError = PS10_SetCanOpenSlave(
                nSlaveDevNr,
                nBusAdd);

            return m_nLastError;
        }

        public Int32 GetCanOpenSlave(Int32 nSlaveDevNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetCanOpenSlave(nSlaveDevNr);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetSlaves()
        {
            Int32 nValue = 0;

            nValue = PS10_GetSlaves(m_nController);
            m_nLastError = GetReadError();

            return nValue;
        }

        public String GetConnectInfo(Int32 nMode)
        {
	        String strMsg;
            StringBuilder strBuffer = new StringBuilder(70);
	        Int32 nStrLen;

            nStrLen=PS10_GetConnectInfo(
		        m_nController,
		        strBuffer,
                strBuffer.Capacity,
                nMode);
	        strMsg=strBuffer.ToString();
            m_nLastError=0;

	        return strMsg;
        }

        public String GetMessage(Int32 nSlaveNr)
        {
            String strMsg;
            StringBuilder strBuffer = new StringBuilder(50);
            Int32 nStrLen;

            nStrLen = PS10_GetMessage(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                strBuffer,
                strBuffer.Capacity);
            strMsg = strBuffer.ToString();
            m_nLastError = GetReadError();

            return strMsg;
        }

        public Int32 GetTerminal()
        {
	        Int32 nValue=0;

            nValue=PS10_GetTerminal(m_nController);
            m_nLastError=GetReadError();

	        return nValue;
        }

        public Int32 SetTerminal(Int32 nMode)
        {
            m_nLastError=PS10_SetTerminal(
                m_nController,
                nMode);

	        return m_nLastError;
        }

        public String GetBoardVersion(Int32 nSlaveNr)
        {
            String strVersion;
            StringBuilder strBuffer = new StringBuilder(50);
            Int32 nStrLen;

            nStrLen = PS10_GetBoardVersion(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                strBuffer,
                strBuffer.Capacity);
            strVersion = strBuffer.ToString();
            m_nLastError = GetReadError();

            return strVersion;
        }

        public String GetSerNumber()
        {
            String strNum;
            StringBuilder strBuffer = new StringBuilder(50);
            Int32 nStrLen;

            nStrLen = PS10_GetSerNumber(
                m_nController,
                strBuffer,
                strBuffer.Capacity);
            strNum = strBuffer.ToString();
            m_nLastError = GetReadError();

            return strNum;
        }

        public Int32 GetError()
        {
	        Int32 nValue=0;

            nValue=PS10_GetError(m_nController);
            m_nLastError=GetReadError();

	        return nValue;
        }

        public Int32 CheckMem()
        {
	        Int32 nCheckSum=0;

            nCheckSum = PS10_CheckMem(m_nController);
            m_nLastError=GetReadError();

            return nCheckSum;
        }

        public Int32 ResetBoard()
        {
            m_nLastError = PS10_ResetBoard(m_nController);

	        return m_nLastError;
        }

        public Int32 ClearError(Int32 nSlaveNr)
        {
            m_nLastError = PS10_ClearError(nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100);

	        return m_nLastError;
        }

        // *** Info ****************************************************************
        // 1 master (connected with USB), 31 slaves (1...31, connected with CanOpen)
        // nSlaveNr=0, function for master control unit
        // nSlaveNr=1...31, function for slave control unit
        // If a function has both parameters (nAxis and nSlaveNr), one can use nAxis or nSlaveNr alternatively!
        // nAxis=1 - axis of master control unit
        // nAxis=2...32 - axis of slave control unit (e.g. axis2=slave1, axis3=slave2)
        // *************************************************************************

        // Operate
        public Int32 MotorInit(Int32 nAxis, Int32 nSlaveNr)
        {
            m_nLastError = PS10_MotorInit(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);

            return m_nLastError;
        }

        public Int32 MotorOn(Int32 nAxis, Int32 nSlaveNr)
        {
            m_nLastError = PS10_MotorOn(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);

            return m_nLastError;
        }

        public Int32 MotorOff(Int32 nAxis, Int32 nSlaveNr)
        {
            m_nLastError = PS10_MotorOff(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);

            return m_nLastError;
        }

        public Int32 GetTargetMode(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetTargetMode(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetTargetMode(Int32 nAxis, Int32 nMode, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetTargetMode(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nMode);

            return m_nLastError;
        }

        public Int32 GetPosition(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetPosition(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetPosition(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetPosition(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 ResetCounter(Int32 nAxis, Int32 nSlaveNr)
        {
            m_nLastError = PS10_ResetCounter(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);

            return m_nLastError;
        }

        public Int32 GetTarget(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetTarget(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetTarget(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetTarget(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GoTarget(Int32 nAxis, Int32 nSlaveNr)
        {
            m_nLastError = PS10_GoTarget(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);

            return m_nLastError;
        }

        public Int32 GoRef(Int32 nAxis, Int32 nRefMode, Int32 nSlaveNr)
        {
            m_nLastError = PS10_GoRef(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nRefMode);

            return m_nLastError;
        }

        public Int32 FreeSwitch(Int32 nAxis, Int32 nSlaveNr)
        {
            m_nLastError = PS10_FreeSwitch(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);

            return m_nLastError;
        }

        public Int32 Stop(Int32 nAxis, Int32 nSlaveNr)
        {
            m_nLastError = PS10_Stop(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);

            return m_nLastError;
        }

        public Int32 GoVel(Int32 nAxis, Int32 nSlaveNr)
        {
            m_nLastError = PS10_GoVel(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);

            return m_nLastError;
        }

        public Int32 StopVel(Int32 nAxis, Int32 nSlaveNr)
        {
            m_nLastError = PS10_StopVel(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);

            return m_nLastError;
        }

        public Int32 GetMotorType(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetMotorType(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetMotorType(Int32 nAxis, Int32 nType, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetMotorType(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nType);

            return m_nLastError;
        }

        public Int32 GetEncLines(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetEncLines(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetEncLines(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetEncLines(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetAxisMonitor(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetAxisMonitor(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetAxisMonitor(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetAxisMonitor(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetAxisState(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetAxisState(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetMoveState(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetMoveState(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetVelState(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetVelState(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetErrorState(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetErrorState(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetRefReady(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetRefReady(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetActF(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetActF(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetEncPos(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetEncPos(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetPosError(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetPosError(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetMaxPosError(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetMaxPosError(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetMaxPosError(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetMaxPosError(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetPosRange(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetPosRange(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        // Adjustments
        public Int32 SaveAxisParams(Int32 nAxis, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SaveAxisParams(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);

            return m_nLastError;
        }

        public Int32 GetAccel(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetAccel(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetAccel(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetAccel(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetRefDecel(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetRefDecel(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetRefDecel(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetRefDecel(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetPosF(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetPosF(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetPosF(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetPosF(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetF(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetF(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetF(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetF(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetSlowRefF(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetSlowRefF(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetSlowRefF(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetSlowRefF(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetFastRefF(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetFastRefF(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetFastRefF(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetFastRefF(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetFreeF(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetFreeF(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetFreeF(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetFreeF(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetMicrostepMode(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetMicrostepMode(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetMicrostepMode(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetMicrostepMode(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetDriveCurrent(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetDriveCurrent(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetDriveCurrent(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetDriveCurrent(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetHoldCurrent(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetHoldCurrent(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetHoldCurrent(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetHoldCurrent(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetPhaseInitTime(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetPhaseInitTime(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetPhaseInitTime(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetPhaseInitTime(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetPhasePwmFreq(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetPhasePwmFreq(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetPhasePwmFreq(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetPhasePwmFreq(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetCurrentLevel(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetCurrentLevel(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetCurrentLevel(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetCurrentLevel(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetServoLoopMax(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetServoLoopMax(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetServoLoopMax(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetServoLoopMax(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        // Software/hardware regulator
        public Int32 GetSampleTime(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetSampleTime(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetSampleTime(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetSampleTime(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetKP(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetKP(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetKP(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetKP(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetKI(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetKI(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetKI(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetKI(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetKD(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetKD(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetKD(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetKD(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetDTime(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetDTime(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetDTime(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetDTime(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetILimit(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetILimit(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetILimit(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetILimit(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        // Hardware/software switches
        public Int32 GetLimitSwitch(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetLimitSwitch(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetLimitSwitch(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetLimitSwitch(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetLimitSwitchMode(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetLimitSwitchMode(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetLimitSwitchMode(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetLimitSwitchMode(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetRefSwitch(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetRefSwitch(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetRefSwitch(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetRefSwitch(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetRefSwitchMode(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetRefSwitchMode(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetRefSwitchMode(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetRefSwitchMode(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetSwitchState(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetSwitchState(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetSwitchHyst(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetSwitchHyst(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetLimitControl(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetLimitControl(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetLimitControl(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetLimitControl(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetLimitMin(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetLimitMin(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetLimitMin(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetLimitMin(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetLimitMax(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetLimitMax(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetLimitMax(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetLimitMax(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetLimitState(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetLimitState(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        // Joystick
        public Int32 JoystickOn(Int32 nSlaveNr)
        {
            m_nLastError = PS10_JoystickOn(nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100);

            return m_nLastError;
        }

        public Int32 JoystickOff(Int32 nSlaveNr)
        {
            m_nLastError = PS10_JoystickOff(nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100);

            return m_nLastError;
        }

        public Int32 GetJoyF(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetJoyF(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetJoyF(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetJoyF(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetJoyZone(Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetJoyZone(nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetJoyZone(Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetJoyZone(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nValue);

            return m_nLastError;
        }

        public Int32 GetJoyZero(Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetJoyZero(nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetJoyZero(Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetJoyZero(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nValue);

            return m_nLastError;
        }

        public Int32 GetJoyButton(Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetJoyButton(nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetJoyButton(Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetJoyButton(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nValue);

            return m_nLastError;
        }

        // Analog & digital I/O
        public Int32 GetDigitalInput(Int32 nPin, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetDigitalInput(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nPin);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetDigitalOutput(Int32 nPin, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetDigitalOutput(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nPin);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetDigitalOutput(Int32 nPin, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetDigitalOutput(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nPin,
                nValue);

            return m_nLastError;
        }

        public Int32 GetAnalogInput(Int32 nInput, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetAnalogInput(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nInput);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetPwmOutput(Int32 nOutput, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetPwmOutput(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nOutput);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetPwmOutput(Int32 nOutput, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetPwmOutput(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nOutput,
                nValue);

            return m_nLastError;
        }

        public Int32 GetOutputMode(Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetOutputMode(nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetOutputMode(Int32 nMode, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetOutputMode(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nMode);

            return m_nLastError;
        }

        public Int32 GetPwmBrake(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetPwmBrake(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetPwmBrake(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetPwmBrake(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetPwmBrakeValue1(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetPwmBrakeValue1(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetPwmBrakeValue1(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetPwmBrakeValue1(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetPwmBrakeValue2(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetPwmBrakeValue2(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetPwmBrakeValue2(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetPwmBrakeValue2(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetPwmBrakeTime(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetPwmBrakeTime(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetPwmBrakeTime(Int32 nAxis, Int32 nValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetPwmBrakeTime(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nValue);

            return m_nLastError;
        }

        public Int32 GetPowerMode(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetPowerMode(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 SetPowerMode(Int32 nAxis, Int32 nMode, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetPowerMode(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nMode);

            return m_nLastError;
        }

        public Int32 GetPowerState(Int32 nAxis, Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetPowerState(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return nValue;
        }

        public Int32 GetEmergencyInput(Int32 nSlaveNr)
        {
            Int32 nValue = 0;

            nValue = PS10_GetEmergencyInput(nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100);
            m_nLastError = GetReadError();

            return nValue;
        }

        // Extended functions
        public Int32 SetStageAttributes(Int32 nAxis, Double pitch, Int32 inc_rev, Double ratio, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetStageAttributes(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                pitch,
                inc_rev,
                ratio);

            return m_nLastError;
        }

        public Int32 SetCalcResol(Int32 nAxis, Double cresol, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetCalcResol(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                cresol);

            return m_nLastError;
        }

        public Double GetPositionEx(Int32 nAxis, Int32 nSlaveNr)
        {
            Double dValue = 0.0;

            dValue = PS10_GetPositionEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetPositionEx(Int32 nAxis, Double dValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetPositionEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetTargetEx(Int32 nAxis, Int32 nSlaveNr)
        {
            Double dValue = 0.0;

            dValue = PS10_GetTargetEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetTargetEx(Int32 nAxis, Double dValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetTargetEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetPosRangeEx(Int32 nAxis, Int32 nSlaveNr)
        {
            Double dValue = 0.0;

            dValue = PS10_GetPosRangeEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Double GetEncPosEx(Int32 nAxis, Int32 nSlaveNr)
        {
            Double dValue = 0.0;

            dValue = PS10_GetEncPosEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Double GetLimitMinEx(Int32 nAxis, Int32 nSlaveNr)
        {
            Double dValue = 0.0;

            dValue = PS10_GetLimitMinEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetLimitMinEx(Int32 nAxis, Double dValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetLimitMinEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetLimitMaxEx(Int32 nAxis, Int32 nSlaveNr)
        {
            Double dValue = 0.0;

            dValue = PS10_GetLimitMaxEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetLimitMaxEx(Int32 nAxis, Double dValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetLimitMaxEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Int32 MoveEx(Int32 nAxis, Double dValue, Boolean bNoInc, Int32 nSlaveNr)
        {
            m_nLastError = PS10_MoveEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                dValue,
                bNoInc?1:0);

            return m_nLastError;
        }

        public Int32 MoveTriggerEx(Int32 nAxis, Int32 nInput, Boolean bHigh, Int32 nSlaveNr)
        {
            m_nLastError = PS10_MoveTriggerEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nInput,
                bHigh ? 1 : 0);

            return m_nLastError;
        }

        public Int32 MoveAnalogInputEx(Int32 nAxis, Int32 nInput, Double dMaxVal, Boolean bNoInc, Int32 nSlaveNr)
        {
            m_nLastError = PS10_MoveAnalogInputEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nInput,
                dMaxVal,
                bNoInc?1:0);

            return m_nLastError;
        }

        public Double GetPosFEx(Int32 nAxis, Int32 nSlaveNr)
        {
            Double dValue = 0.0;

            dValue = PS10_GetPosFEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetPosFEx(Int32 nAxis, Double dValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetPosFEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetFEx(Int32 nAxis, Int32 nSlaveNr)
        {
            Double dValue = 0.0;

            dValue = PS10_GetFEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetFEx(Int32 nAxis, Double dValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetFEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetSlowRefFEx(Int32 nAxis, Int32 nSlaveNr)
        {
            Double dValue = 0.0;

            dValue = PS10_GetSlowRefFEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetSlowRefFEx(Int32 nAxis, Double dValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetSlowRefFEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetFastRefFEx(Int32 nAxis, Int32 nSlaveNr)
        {
            Double dValue = 0.0;

            dValue = PS10_GetFastRefFEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetFastRefFEx(Int32 nAxis, Double dValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetFastRefFEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetFreeFEx(Int32 nAxis, Int32 nSlaveNr)
        {
            Double dValue = 0.0;

            dValue = PS10_GetFreeFEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetFreeFEx(Int32 nAxis, Double dValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetFreeFEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetJoyFEx(Int32 nAxis, Int32 nSlaveNr)
        {
            Double dValue = 0.0;

            dValue = PS10_GetJoyFEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetJoyFEx(Int32 nAxis, Double dValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetJoyFEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetActFEx(Int32 nAxis, Int32 nSlaveNr)
        {
            Double dValue = 0.0;

            dValue = PS10_GetActFEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Double GetAccelEx(Int32 nAxis, Int32 nSlaveNr)
        {
            Double dValue = 0.0;

            dValue = PS10_GetAccelEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetAccelEx(Int32 nAxis, Double dValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetAccelEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                dValue);

            return m_nLastError;
        }

        public Double GetRefDecelEx(Int32 nAxis, Int32 nSlaveNr)
        {
            Double dValue = 0.0;

            dValue = PS10_GetRefDecelEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis);
            m_nLastError = GetReadError();

            return dValue;
        }

        public Int32 SetRefDecelEx(Int32 nAxis, Double dValue, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SetRefDecelEx(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                dValue);

            return m_nLastError;
        }

        public String GetOWISidData(Int32 nAxis, Int32 nParamNum, Int32 nSlaveNr)
        {
            String strMsg;
            StringBuilder strBuffer = new StringBuilder(150);
            Int32 nStrLen;

            nStrLen = PS10_GetOWISidData(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                nParamNum,
                strBuffer,
                strBuffer.Capacity);
            strMsg = strBuffer.ToString();
            m_nLastError = GetReadError();

            return strMsg;
        }

        public Int32 LoadTextFile(Int32 nAxis, String strFile, Int32 nSlaveNr)
        {
            m_nLastError = PS10_LoadTextFile(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                strFile);

            return m_nLastError;
        }

        public Int32 SaveTextFile(Int32 nAxis, String strFile, Int32 nSlaveNr)
        {
            m_nLastError = PS10_SaveTextFile(
                (nSlaveNr == 0 ? m_nController : nSlaveNr + m_nController * 100),
                nAxis,
                strFile);

            return m_nLastError;
        }

        // Communication
        public Int32 LogFile(Boolean bOpen, String strFile, Boolean bAppend, Int32 nMode)
        {
            m_nLastError = PS10_LogFile(
                m_nController,
                bOpen?1:0,
                strFile,
                bAppend?1:0,
                nMode);

            return m_nLastError;
        }

        public String CmdAns(String strCmd, Boolean bRequest)
        {
            String strMsg;
            StringBuilder strBuffer = new StringBuilder(50);
            Int32 nStrLen;

            nStrLen = PS10_CmdAns(
                m_nController,
                strCmd,
                strBuffer,
                strBuffer.Capacity,
                bRequest?1:0);
            strMsg = strBuffer.ToString();
            m_nLastError = GetReadError();

            return strMsg;
        }

        public String CmdAnsEx(String strCmd, Boolean bRequest, Int32 nBreak)
        {
            String strMsg;
            StringBuilder strBuffer = new StringBuilder(50);
            Int32 nStrLen;

            nStrLen = PS10_CmdAnsEx(
                m_nController,
                strCmd,
                strBuffer,
                strBuffer.Capacity,
                bRequest?1:0,
                nBreak);
            strMsg = strBuffer.ToString();
            m_nLastError = GetReadError();

            return strMsg;
        }

        public Int32 GetReadError()
        {
            return  PS10_GetReadError(m_nController);
        }
    }
}
