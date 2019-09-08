using System;
using System.Runtime.InteropServices;

namespace RemoteMIDI
{
    public class MIDIMessage : EventArgs
    {
        public byte[] Data { get; set; }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MIDIINCAPS
    {
        public ushort wMid;
        public ushort wPid;
        public uint vDriverVersion;     // MMVERSION
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;
        public uint dwSupport;
    }

    public enum MMRESULT : uint
    {
        MMSYSERR_NOERROR = 0,
        MMSYSERR_ERROR = 1,
        MMSYSERR_BADDEVICEID = 2,
        MMSYSERR_NOTENABLED = 3,
        MMSYSERR_ALLOCATED = 4,
        MMSYSERR_INVALHANDLE = 5,
        MMSYSERR_NODRIVER = 6,
        MMSYSERR_NOMEM = 7,
        MMSYSERR_NOTSUPPORTED = 8,
        MMSYSERR_BADERRNUM = 9,
        MMSYSERR_INVALFLAG = 10,
        MMSYSERR_INVALPARAM = 11,
        MMSYSERR_HANDLEBUSY = 12,
        MMSYSERR_INVALIDALIAS = 13,
        MMSYSERR_BADDB = 14,
        MMSYSERR_KEYNOTFOUND = 15,
        MMSYSERR_READERROR = 16,
        MMSYSERR_WRITEERROR = 17,
        MMSYSERR_DELETEERROR = 18,
        MMSYSERR_VALNOTFOUND = 19,
        MMSYSERR_NODRIVERCB = 20,
        WAVERR_BADFORMAT = 32,
        WAVERR_STILLPLAYING = 33,
        WAVERR_UNPREPARED = 34
    }

    public class InputPort
    {
        private readonly NativeMethods.MidiInProc midiInProc;
        private IntPtr handle;
        public bool Started = false;
        public bool Opened = false;

        public InputPort()
        {
            this.midiInProc = new NativeMethods.MidiInProc(this.MidiProc);
            this.handle = IntPtr.Zero;
        }

        public static int InputCount => NativeMethods.midiInGetNumDevs();
        public static MMRESULT GetDeviceInfo(uint uDeviceID, ref MIDIINCAPS caps, uint cbMidiInCaps) =>
            NativeMethods.midiInGetDevCaps(uDeviceID, ref caps, cbMidiInCaps);

        public bool Close()
        {
            this.Opened = false;
            this.handle = IntPtr.Zero; 
            return NativeMethods.midiInClose(this.handle)
                == NativeMethods.MMSYSERR_NOERROR;
        }

        public bool Open(int id)
        {
            this.Opened = NativeMethods.midiInOpen(
                out this.handle,
                id,
                this.midiInProc,
                IntPtr.Zero,
                NativeMethods.CALLBACK_FUNCTION)
                == NativeMethods.MMSYSERR_NOERROR; ;
            return this.Opened;
        }

        public bool Start()
        {
            this.Started = NativeMethods.midiInStart(this.handle)
                == NativeMethods.MMSYSERR_NOERROR; ;
            return this.Started;
        }

        public bool Stop()
        {
            this.Started = false;
            return NativeMethods.midiInStop(this.handle)
                == NativeMethods.MMSYSERR_NOERROR;
        }

        public event EventHandler<MIDIMessage> MIDIInputReceived;
        
        private void MidiProc(IntPtr hMidiIn,
            int wMsg,
            IntPtr dwInstance,
            int dwParam1,
            int dwParam2)
        {
            // Receive messages here
            var e = new MIDIMessage()
            {
                Data = new byte[]
                {
                    (byte)wMsg,
                    (byte)dwParam1,
                    (byte)dwParam2
                }
            };
            MIDIInputReceived?.Invoke(this, e);
        }
    }

    internal static class NativeMethods
    {
        internal const int MMSYSERR_NOERROR = 0;
        internal const int CALLBACK_FUNCTION = 0x00030000;

        internal delegate void MidiInProc(
            IntPtr hMidiIn,
            int wMsg,
            IntPtr dwInstance,
            int dwParam1,
            int dwParam2);


        [DllImport("winmm.dll", SetLastError = true)]
        internal static extern MMRESULT midiInGetDevCaps(uint uDeviceID, ref MIDIINCAPS caps, uint cbMidiInCaps);


        [DllImport("winmm.dll")]
        internal static extern int midiInGetNumDevs();

        [DllImport("winmm.dll")]
        internal static extern int midiInClose(
            IntPtr hMidiIn);

        [DllImport("winmm.dll")]
        internal static extern int midiInOpen(
            out IntPtr lphMidiIn,
            int uDeviceID,
            MidiInProc dwCallback,
            IntPtr dwCallbackInstance,
            int dwFlags);

        [DllImport("winmm.dll")]
        internal static extern int midiInStart(
            IntPtr hMidiIn);

        [DllImport("winmm.dll")]
        internal static extern int midiInStop(
            IntPtr hMidiIn);
    }
}
