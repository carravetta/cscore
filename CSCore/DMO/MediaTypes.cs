﻿using System;
using System.Collections.Generic;

namespace CSCore.DMO
{
    /// <summary>
    /// Contains defined MediaTypes and can provides methods to convert between AudioEncoding and MediaType.
    /// </summary>
    public static class MediaTypes
    {
        //http://msdn.microsoft.com/en-us/library/windows/desktop/dd317599(v=vs.85).aspx
        public static readonly Guid MediaTypeAudio = new Guid("73647561-0000-0010-8000-00AA00389B71");

        public static readonly Guid MEDIATYPE_Pcm = new Guid((int)AudioEncoding.Pcm, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_Adpcm = new Guid((int)AudioEncoding.Adpcm, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_IeeeFloat = new Guid((int)AudioEncoding.IeeeFloat, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_Vselp = new Guid((int)AudioEncoding.Vselp, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_IbmCvsd = new Guid((int)AudioEncoding.IbmCvsd, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_ALaw = new Guid((int)AudioEncoding.ALaw, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_MuLaw = new Guid((int)AudioEncoding.MuLaw, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_Dts = new Guid((int)AudioEncoding.Dts, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_Drm = new Guid((int)AudioEncoding.Drm, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_WMAVOICE9 = new Guid((int)AudioEncoding.WAVE_FORMAT_WMAVOICE9, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_OkiAdpcm = new Guid((int)AudioEncoding.OkiAdpcm, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_ImaAdpcm = new Guid((int)AudioEncoding.ImaAdpcm, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_DviAdpcm = new Guid((int)AudioEncoding.DviAdpcm, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_MediaspaceAdpcm = new Guid((int)AudioEncoding.MediaspaceAdpcm, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_SierraAdpcm = new Guid((int)AudioEncoding.SierraAdpcm, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_G723Adpcm = new Guid((int)AudioEncoding.G723Adpcm, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_DigiStd = new Guid((int)AudioEncoding.DigiStd, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_DigiFix = new Guid((int)AudioEncoding.DigiFix, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_DialogicOkiAdpcm = new Guid((int)AudioEncoding.DialogicOkiAdpcm, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_MediaVisionAdpcm = new Guid((int)AudioEncoding.MediaVisionAdpcm, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_CUCodec = new Guid((int)AudioEncoding.CUCodec, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_YamahaAdpcm = new Guid((int)AudioEncoding.YamahaAdpcm, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_SonarC = new Guid((int)AudioEncoding.SonarC, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_DspGroupTrueSpeech = new Guid((int)AudioEncoding.DspGroupTrueSpeech, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_EchoSpeechCorporation1 = new Guid((int)AudioEncoding.EchoSpeechCorporation1, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_AudioFileAf36 = new Guid((int)AudioEncoding.AudioFileAf36, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_Aptx = new Guid((int)AudioEncoding.Aptx, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_AudioFileAf10 = new Guid((int)AudioEncoding.AudioFileAf10, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_Prosody1612 = new Guid((int)AudioEncoding.Prosody1612, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_Lrc = new Guid((int)AudioEncoding.Lrc, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_DolbyAc2 = new Guid((int)AudioEncoding.DolbyAc2, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_Gsm610 = new Guid((int)AudioEncoding.Gsm610, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_MsnAudio = new Guid((int)AudioEncoding.MsnAudio, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_AntexAdpcme = new Guid((int)AudioEncoding.AntexAdpcme, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_ControlResVqlpc = new Guid((int)AudioEncoding.ControlResVqlpc, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_DigiReal = new Guid((int)AudioEncoding.DigiReal, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_DigiAdpcm = new Guid((int)AudioEncoding.DigiAdpcm, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_ControlResCr10 = new Guid((int)AudioEncoding.ControlResCr10, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_NMS_VBXADPCM = new Guid((int)AudioEncoding.WAVE_FORMAT_NMS_VBXADPCM, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_CS_IMAADPCM = new Guid((int)AudioEncoding.WAVE_FORMAT_CS_IMAADPCM, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_ECHOSC3 = new Guid((int)AudioEncoding.WAVE_FORMAT_ECHOSC3, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_ROCKWELL_ADPCM = new Guid((int)AudioEncoding.WAVE_FORMAT_ROCKWELL_ADPCM, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_ROCKWELL_DIGITALK = new Guid((int)AudioEncoding.WAVE_FORMAT_ROCKWELL_DIGITALK, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_XEBEC = new Guid((int)AudioEncoding.WAVE_FORMAT_XEBEC, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_G721_ADPCM = new Guid((int)AudioEncoding.WAVE_FORMAT_G721_ADPCM, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_G728_CELP = new Guid((int)AudioEncoding.WAVE_FORMAT_G728_CELP, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_MSG723 = new Guid((int)AudioEncoding.WAVE_FORMAT_MSG723, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_Mpeg = new Guid((int)AudioEncoding.Mpeg, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_RT24 = new Guid((int)AudioEncoding.WAVE_FORMAT_RT24, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_PAC = new Guid((int)AudioEncoding.WAVE_FORMAT_PAC, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_MP3 = new Guid((int)AudioEncoding.MpegLayer3, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_LUCENT_G723 = new Guid((int)AudioEncoding.WAVE_FORMAT_LUCENT_G723, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_CIRRUS = new Guid((int)AudioEncoding.WAVE_FORMAT_CIRRUS, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_ESPCM = new Guid((int)AudioEncoding.WAVE_FORMAT_ESPCM, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_VOXWARE = new Guid((int)AudioEncoding.WAVE_FORMAT_VOXWARE, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_CANOPUS_ATRAC = new Guid((int)AudioEncoding.WAVE_FORMAT_CANOPUS_ATRAC, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_G726_ADPCM = new Guid((int)AudioEncoding.WAVE_FORMAT_G726_ADPCM, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_G722_ADPCM = new Guid((int)AudioEncoding.WAVE_FORMAT_G722_ADPCM, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_DSAT_DISPLAY = new Guid((int)AudioEncoding.WAVE_FORMAT_DSAT_DISPLAY, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_VOXWARE_BYTE_ALIGNED = new Guid((int)AudioEncoding.WAVE_FORMAT_VOXWARE_BYTE_ALIGNED, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_VOXWARE_AC8 = new Guid((int)AudioEncoding.WAVE_FORMAT_VOXWARE_AC8, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_VOXWARE_AC10 = new Guid((int)AudioEncoding.WAVE_FORMAT_VOXWARE_AC10, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_VOXWARE_AC16 = new Guid((int)AudioEncoding.WAVE_FORMAT_VOXWARE_AC16, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_VOXWARE_AC20 = new Guid((int)AudioEncoding.WAVE_FORMAT_VOXWARE_AC20, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_VOXWARE_RT24 = new Guid((int)AudioEncoding.WAVE_FORMAT_VOXWARE_RT24, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_VOXWARE_RT29 = new Guid((int)AudioEncoding.WAVE_FORMAT_VOXWARE_RT29, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_VOXWARE_RT29HW = new Guid((int)AudioEncoding.WAVE_FORMAT_VOXWARE_RT29HW, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_VOXWARE_VR12 = new Guid((int)AudioEncoding.WAVE_FORMAT_VOXWARE_VR12, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_VOXWARE_VR18 = new Guid((int)AudioEncoding.WAVE_FORMAT_VOXWARE_VR18, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_VOXWARE_TQ40 = new Guid((int)AudioEncoding.WAVE_FORMAT_VOXWARE_TQ40, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_SOFTSOUND = new Guid((int)AudioEncoding.WAVE_FORMAT_SOFTSOUND, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_VOXWARE_TQ60 = new Guid((int)AudioEncoding.WAVE_FORMAT_VOXWARE_TQ60, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_MSRT24 = new Guid((int)AudioEncoding.WAVE_FORMAT_MSRT24, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_G729A = new Guid((int)AudioEncoding.WAVE_FORMAT_G729A, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_MVI_MVI2 = new Guid((int)AudioEncoding.WAVE_FORMAT_MVI_MVI2, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_DF_G726 = new Guid((int)AudioEncoding.WAVE_FORMAT_DF_G726, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_DF_GSM610 = new Guid((int)AudioEncoding.WAVE_FORMAT_DF_GSM610, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_ISIAUDIO = new Guid((int)AudioEncoding.WAVE_FORMAT_ISIAUDIO, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_ONLIVE = new Guid((int)AudioEncoding.WAVE_FORMAT_ONLIVE, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_SBC24 = new Guid((int)AudioEncoding.WAVE_FORMAT_SBC24, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_DOLBY_AC3_SPDIF = new Guid((int)AudioEncoding.WAVE_FORMAT_DOLBY_AC3_SPDIF, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_MEDIASONIC_G723 = new Guid((int)AudioEncoding.WAVE_FORMAT_MEDIASONIC_G723, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_PROSODY_8KBPS = new Guid((int)AudioEncoding.WAVE_FORMAT_PROSODY_8KBPS, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_ZYXEL_ADPCM = new Guid((int)AudioEncoding.WAVE_FORMAT_ZYXEL_ADPCM, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_PHILIPS_LPCBB = new Guid((int)AudioEncoding.WAVE_FORMAT_PHILIPS_LPCBB, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_PACKED = new Guid((int)AudioEncoding.WAVE_FORMAT_PACKED, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_MALDEN_PHONYTALK = new Guid((int)AudioEncoding.WAVE_FORMAT_MALDEN_PHONYTALK, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_Gsm = new Guid((int)AudioEncoding.Gsm, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_G729 = new Guid((int)AudioEncoding.G729, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_G723 = new Guid((int)AudioEncoding.G723, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_Acelp = new Guid((int)AudioEncoding.Acelp, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_RAW_AAC1 = new Guid((int)AudioEncoding.WAVE_FORMAT_RAW_AAC1, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_RHETOREX_ADPCM = new Guid((int)AudioEncoding.WAVE_FORMAT_RHETOREX_ADPCM, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_IRAT = new Guid((int)AudioEncoding.WAVE_FORMAT_IRAT, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_VIVO_G723 = new Guid((int)AudioEncoding.WAVE_FORMAT_VIVO_G723, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_VIVO_SIREN = new Guid((int)AudioEncoding.WAVE_FORMAT_VIVO_SIREN, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_DIGITAL_G723 = new Guid((int)AudioEncoding.WAVE_FORMAT_DIGITAL_G723, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_SANYO_LD_ADPCM = new Guid((int)AudioEncoding.WAVE_FORMAT_SANYO_LD_ADPCM, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_SIPROLAB_ACEPLNET = new Guid((int)AudioEncoding.WAVE_FORMAT_SIPROLAB_ACEPLNET, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_SIPROLAB_ACELP4800 = new Guid((int)AudioEncoding.WAVE_FORMAT_SIPROLAB_ACELP4800, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_SIPROLAB_ACELP8V3 = new Guid((int)AudioEncoding.WAVE_FORMAT_SIPROLAB_ACELP8V3, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_SIPROLAB_G729 = new Guid((int)AudioEncoding.WAVE_FORMAT_SIPROLAB_G729, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_SIPROLAB_G729A = new Guid((int)AudioEncoding.WAVE_FORMAT_SIPROLAB_G729A, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_SIPROLAB_KELVIN = new Guid((int)AudioEncoding.WAVE_FORMAT_SIPROLAB_KELVIN, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_G726ADPCM = new Guid((int)AudioEncoding.WAVE_FORMAT_G726ADPCM, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_QUALCOMM_PUREVOICE = new Guid((int)AudioEncoding.WAVE_FORMAT_QUALCOMM_PUREVOICE, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_QUALCOMM_HALFRATE = new Guid((int)AudioEncoding.WAVE_FORMAT_QUALCOMM_HALFRATE, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_TUBGSM = new Guid((int)AudioEncoding.WAVE_FORMAT_TUBGSM, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_MSAUDIO1 = new Guid((int)AudioEncoding.WAVE_FORMAT_MSAUDIO1, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_WMAUDIO2 = new Guid((int)AudioEncoding.WAVE_FORMAT_WMAUDIO2, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_WMAUDIO3 = new Guid((int)AudioEncoding.WAVE_FORMAT_WMAUDIO3, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_WMAUDIO_LOSSLESS = new Guid((int)AudioEncoding.WAVE_FORMAT_WMAUDIO_LOSSLESS, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_WMASPDIF = new Guid((int)AudioEncoding.WAVE_FORMAT_WMASPDIF, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_UNISYS_NAP_ADPCM = new Guid((int)AudioEncoding.WAVE_FORMAT_UNISYS_NAP_ADPCM, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_UNISYS_NAP_ULAW = new Guid((int)AudioEncoding.WAVE_FORMAT_UNISYS_NAP_ULAW, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_UNISYS_NAP_ALAW = new Guid((int)AudioEncoding.WAVE_FORMAT_UNISYS_NAP_ALAW, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_UNISYS_NAP_16K = new Guid((int)AudioEncoding.WAVE_FORMAT_UNISYS_NAP_16K, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_CREATIVE_ADPCM = new Guid((int)AudioEncoding.WAVE_FORMAT_CREATIVE_ADPCM, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_CREATIVE_FASTSPEECH8 = new Guid((int)AudioEncoding.WAVE_FORMAT_CREATIVE_FASTSPEECH8, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_CREATIVE_FASTSPEECH10 = new Guid((int)AudioEncoding.WAVE_FORMAT_CREATIVE_FASTSPEECH10, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_UHER_ADPCM = new Guid((int)AudioEncoding.WAVE_FORMAT_UHER_ADPCM, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_QUARTERDECK = new Guid((int)AudioEncoding.WAVE_FORMAT_QUARTERDECK, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_ILINK_VC = new Guid((int)AudioEncoding.WAVE_FORMAT_ILINK_VC, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_RAW_SPORT = new Guid((int)AudioEncoding.WAVE_FORMAT_RAW_SPORT, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_ESST_AC3 = new Guid((int)AudioEncoding.WAVE_FORMAT_ESST_AC3, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_IPI_HSX = new Guid((int)AudioEncoding.WAVE_FORMAT_IPI_HSX, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_IPI_RPELP = new Guid((int)AudioEncoding.WAVE_FORMAT_IPI_RPELP, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_CS2 = new Guid((int)AudioEncoding.WAVE_FORMAT_CS2, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_SONY_SCX = new Guid((int)AudioEncoding.WAVE_FORMAT_SONY_SCX, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_FM_TOWNS_SND = new Guid((int)AudioEncoding.WAVE_FORMAT_FM_TOWNS_SND, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_BTV_DIGITAL = new Guid((int)AudioEncoding.WAVE_FORMAT_BTV_DIGITAL, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_QDESIGN_MUSIC = new Guid((int)AudioEncoding.WAVE_FORMAT_QDESIGN_MUSIC, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_VME_VMPCM = new Guid((int)AudioEncoding.WAVE_FORMAT_VME_VMPCM, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_TPC = new Guid((int)AudioEncoding.WAVE_FORMAT_TPC, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_OLIGSM = new Guid((int)AudioEncoding.WAVE_FORMAT_OLIGSM, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_OLIADPCM = new Guid((int)AudioEncoding.WAVE_FORMAT_OLIADPCM, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_OLICELP = new Guid((int)AudioEncoding.WAVE_FORMAT_OLICELP, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_OLISBC = new Guid((int)AudioEncoding.WAVE_FORMAT_OLISBC, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_OLIOPR = new Guid((int)AudioEncoding.WAVE_FORMAT_OLIOPR, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_LH_CODEC = new Guid((int)AudioEncoding.WAVE_FORMAT_LH_CODEC, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_NORRIS = new Guid((int)AudioEncoding.WAVE_FORMAT_NORRIS, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_SOUNDSPACE_MUSICOMPRESS = new Guid((int)AudioEncoding.WAVE_FORMAT_SOUNDSPACE_MUSICOMPRESS, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_MPEG_HEAAC = new Guid((int)AudioEncoding.WAVE_FORMAT_MPEG_HEAAC, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_DVM = new Guid((int)AudioEncoding.WAVE_FORMAT_DVM, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_Extensible = new Guid((int)AudioEncoding.Extensible, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_WAVE_FORMAT_DEVELOPMENT = new Guid((int)AudioEncoding.WAVE_FORMAT_DEVELOPMENT, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Converts a Mediatype-value to a AudioEncoding-value.
        /// </summary>
        /// <param name="mediaType"></param>
        /// <returns></returns>
        public static AudioEncoding EncodingFromMediaType(Guid mediaType)
        {
            var bytes = mediaType.ToByteArray();
            int value = BitConverter.ToInt32(bytes, 0);
            if (Enum.IsDefined(typeof(AudioEncoding), value))
                return (AudioEncoding)value;

            throw new ArgumentException("Invalid mediaType.");
        }

        /// <summary>
        /// Converts a AudioEncoding-value to a Mediatype-value.
        /// </summary>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static Guid MediaTypeFromEncoding(AudioEncoding encoding)
        {
            if(Enum.IsDefined(typeof(AudioEncoding), (int)encoding))
                return new Guid((int)encoding, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

            throw new ArgumentException("Invalid encoding.");
        }
    }
}