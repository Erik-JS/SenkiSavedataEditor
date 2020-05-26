using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenkiSaveEditor
{
    class Savedata
    {

        public static byte[] data;

        public static bool IsLittleEndian = false;

        public static string[] CharacterDescriptions = new string[]
        {
            "Pegasus Seiya",
            "Sagittarius Seiya",
            "Odin Seiya",
            "Dragon Shiryu",
            "Cygnus Hyoga",
            "Andromeda Shun",
            "Phoenix Ikki",
            "Eagle Marin",
            "Ophiuchus Shaina",
            "Unicorn Jabu",
             "Aries Mu",
             "Taurus Aldebaran",
             "Gemini ???",
             "Gemini Saga",
             "Cancer Deathmask",
             "Leo Aiolia",
             "Virgo Shaka",
             "Libra Dohko",
             "Scorpio Miro",
             "Sagittarius Aiolos",
             "Capricorn Shura",
             "Aquarius Camus",
             "Pisces Aphrodite",
             "Siren Sorento",
             "Sea Dragon Kanon",
             "Wyvern Rhadamanthys"
        };

        public struct CharacterInfo
        {
            public int[] GeneralInfo; // 0x00: ID, Status, Accessible, 0x0C, 0x10, 0x14, 0x18, 0x1C, 0x20, 0x24 (level?), 0x28 (exp?)
            public ushort[] Stats; // 0x2C: Energy, Cosmo, Attack, Defense, Luck, 0x36
        }

        public static bool LoadFromFile(string filename)
        {
            //byte[] tmpData;
            try
            {
                data = File.ReadAllBytes(filename);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.GetType().Name + "\n" + ex.Message, "LoadFromFile", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static bool WriteToFile(string filename)
        {
            try
            {
                File.WriteAllBytes(filename, data);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().Name + "\n" + ex.Message, "WriteToFile", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public static int GetInt32(int location)
        {
            int value = BitConverter.ToInt32(data, location);
            byte[] tempArray = BitConverter.GetBytes(value);
            Array.Reverse(tempArray);
            return BitConverter.ToInt32(tempArray, 0);
        }

        public static void SetInt32(int location, int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            Array.Reverse(bytes);
            Array.Copy(bytes, 0, data, location, 4);
        }

        public static ushort GetUInt16(int location)
        {
            ushort value = BitConverter.ToUInt16(data, location);
            byte[] tempArray = BitConverter.GetBytes(value);
            Array.Reverse(tempArray);
            return BitConverter.ToUInt16(tempArray, 0);
        }

        public static void SetUInt16(int location, ushort value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            Array.Reverse(bytes);
            Array.Copy(bytes, 0, data, location, 2);
        }

        public static CharacterInfo GetCharacterInfo(int charindex)
        {
            var ci = new CharacterInfo() { GeneralInfo = new int[11], Stats = new ushort[6] };

            for (int i = 0; i < ci.GeneralInfo.Length; i++)
                ci.GeneralInfo[i] = GetInt32(0xD0 + (charindex * 0x64) + (i * 4));

            for (int i = 0; i < ci.Stats.Length; i++)
                ci.Stats[i] = GetUInt16(0xFC + (charindex * 0x64) + (i * 2));

            return ci;
        }

        public static void SetCharacterInfo(int charindex, CharacterInfo newCI)
        {
            for (int i = 0; i < newCI.GeneralInfo.Length; i++)
                SetInt32(0xD0 + (charindex * 0x64) + (i * 4), newCI.GeneralInfo[i]);

            for (int i = 0; i < newCI.Stats.Length; i++)
                SetUInt16(0xFC + (charindex * 0x64) + (i * 2), newCI.Stats[i]);
        }


    }
}
