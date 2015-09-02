﻿using System.Collections.Generic;

namespace HiraKana
{
    class RomajiToKana
    {
        // Romaji-to-hiragana table
        public static readonly IDictionary<string, string> table =
            new Dictionary<string, string>
        {
                {"a", "あ"},
     {"i", "い"},
     {"u", "う"},
     {"e", "え"},
     {"o", "お"},
     {"yi", "い"},
     {"wu", "う"},
                {"whu", "う"},
     {"xa", "ぁ"},
     {"xi", "ぃ"},
     {"xu", "ぅ"},
     {"xe", "ぇ"},
     {"xo", "ぉ"},
     {"xyi", "ぃ"},
                {"xye", "ぇ"},
     {"ye", "いぇ"},
     {"wha", "うぁ"},
     {"whi", "うぃ"},
     {"whe", "うぇ"},
     {"who", "うぉ"},
                {"wi", "うぃ"},
     {"we", "うぇ"},
     {"va", "ゔぁ"},
     {"vi", "ゔぃ"},
     {"vu", "ゔ"},
     {"ve", "ゔぇ"},
                {"vo", "ゔぉ"},
     {"vya", "ゔゃ"},
     {"vyi", "ゔぃ"},
     {"vyu", "ゔゅ"},
     {"vye", "ゔぇ"},
     {"vyo", "ゔょ"},
                {"ka", "か"},
     {"ki", "き"},
     {"ku", "く"},
     {"ke", "け"},
     {"ko", "こ"},
     {"lka", "ヵ"},
     {"lke", "ヶ"},
                {"xka", "ヵ"},
     {"xke", "ヶ"},
     {"kya", "きゃ"},
     {"kyi", "きぃ"},
     {"kyu", "きゅ"},
     {"kye", "きぇ"},
                {"kyo", "きょ"},
     {"qya", "くゃ"},
     {"qyu", "くゅ"},
     {"qyo", "くょ"},
     {"qwa", "くぁ"},
     {"qwi", "くぃ"},
                {"qwu", "くぅ"},
     {"qwe", "くぇ"},
     {"qwo", "くぉ"},
     {"qa", "くぁ"},
     {"qi", "くぃ"},
     {"qe", "くぇ"},
                {"qo", "くぉ"},
     {"kwa", "くぁ"},
     {"qyi", "くぃ"},
     {"qye", "くぇ"},
     {"ga", "が"},
     {"gi", "ぎ"},
     {"gu", "ぐ"},
                {"ge", "げ"},
     {"go", "ご"},
     {"gya", "ぎゃ"},
     {"gyi", "ぎぃ"},
     {"gyu", "ぎゅ"},
     {"gye", "ぎぇ"},
     {"gyo", "ぎょ"},
                {"gwa", "ぐぁ"},
     {"gwi", "ぐぃ"},
     {"gwu", "ぐぅ"},
     {"gwe", "ぐぇ"},
     {"gwo", "ぐぉ"},
     {"sa", "さ"},
     {"si", "し"},
                {"shi", "し"},
     {"su", "す"},
     {"se", "せ"},
     {"so", "そ"},
     {"za", "ざ"},
     {"zi", "じ"},
     {"zu", "ず"},
     {"ze", "ぜ"},
                {"zo", "ぞ"},
     {"ji", "じ"},
     {"sya", "しゃ"},
     {"syi", "しぃ"},
     {"syu", "しゅ"},
     {"sye", "しぇ"},
     {"syo", "しょ"},
                {"sha", "しゃ"},
     {"shu", "しゅ"},
     {"she", "しぇ"},
     {"sho", "しょ"},
     {"swa", "すぁ"},
     {"swi", "すぃ"},
                {"swu", "すぅ"},
     {"swe", "すぇ"},
     {"swo", "すぉ"},
     {"zya", "じゃ"},
     {"zyi", "じぃ"},
     {"zyu", "じゅ"},
                {"zye", "じぇ"},
     {"zyo", "じょ"},
     {"ja", "じゃ"},
     {"ju", "じゅ"},
     {"je", "じぇ"},
     {"jo", "じょ"},
     {"jya", "じゃ"},
                {"jyi", "じぃ"},
     {"jyu", "じゅ"},
     {"jye", "じぇ"},
     {"jyo", "じょ"},
     {"ta", "た"},
     {"ti", "ち"},
     {"tu", "つ"},
                {"te", "て"},
     {"to", "と"},
     {"chi", "ち"},
     {"tsu", "つ"},
     {"ltu", "っ"},
     {"xtu", "っ"},
     {"tya", "ちゃ"},
                {"tyi", "ちぃ"},
     {"tyu", "ちゅ"},
     {"tye", "ちぇ"},
     {"tyo", "ちょ"},
     {"cha", "ちゃ"},
     {"chu", "ちゅ"},
                {"che", "ちぇ"},
     {"cho", "ちょ"},
     {"cya", "ちゃ"},
     {"cyi", "ちぃ"},
     {"cyu", "ちゅ"},
     {"cye", "ちぇ"},
                {"cyo", "ちょ"},
     {"tsa", "つぁ"},
     {"tsi", "つぃ"},
     {"tse", "つぇ"},
     {"tso", "つぉ"},
     {"tha", "てゃ"},
                {"thi", "てぃ"},
     {"thu", "てゅ"},
     {"the", "てぇ"},
     {"tho", "てょ"},
     {"twa", "とぁ"},
     {"twi", "とぃ"},
                {"twu", "とぅ"},
     {"twe", "とぇ"},
     {"two", "とぉ"},
     {"da", "だ"},
     {"di", "ぢ"},
     {"du", "づ"},
     {"de", "で"},
                {"do", "ど"},
     {"dya", "ぢゃ"},
     {"dyi", "ぢぃ"},
     {"dyu", "ぢゅ"},
     {"dye", "ぢぇ"},
     {"dyo", "ぢょ"},
     {"dha", "でゃ"},
                {"dhi", "でぃ"},
     {"dhu", "でゅ"},
     {"dhe", "でぇ"},
     {"dho", "でょ"},
     {"dwa", "どぁ"},
     {"dwi", "どぃ"},
     {"dwu", "どぅ"},
                {"dwe", "どぇ"},
     {"dwo", "どぉ"},
     {"na", "な"},
     {"ni", "に"},
     {"nu", "ぬ"},
     {"ne", "ね"},
     {"no", "の"},
                {"nya", "にゃ"},
     {"nyi", "にぃ"},
     {"nyu", "にゅ"},
     {"nye", "にぇ"},
     {"nyo", "にょ"},
     {"ha", "は"},
     {"hi", "ひ"},
                {"hu", "ふ"},
     {"he", "へ"},
     {"ho", "ほ"},
     {"fu", "ふ"},
     {"hya", "ひゃ"},
     {"hyi", "ひぃ"},
     {"hyu", "ひゅ"},
                {"hye", "ひぇ"},
     {"hyo", "ひょ"},
     {"fya", "ふゃ"},
     {"fyu", "ふゅ"},
     {"fyo", "ふょ"},
     {"fwa", "ふぁ"},
     {"fwi", "ふぃ"},
                {"fwu", "ふぅ"},
     {"fwe", "ふぇ"},
     {"fwo", "ふぉ"},
     {"fa", "ふぁ"},
     {"fi", "ふぃ"},
     {"fe", "ふぇ"},
     {"fo", "ふぉ"},
                {"fyi", "ふぃ"},
     {"fye", "ふぇ"},
     {"ba", "ば"},
     {"bi", "び"},
     {"bu", "ぶ"},
     {"be", "べ"},
     {"bo", "ぼ"},
     {"bya", "びゃ"},
                {"byi", "びぃ"},
     {"byu", "びゅ"},
     {"bye", "びぇ"},
     {"byo", "びょ"},
     {"pa", "ぱ"},
     {"pi", "ぴ"},
     {"pu", "ぷ"},
     {"pe", "ぺ"},
                {"po", "ぽ"},
     {"pya", "ぴゃ"},
     {"pyi", "ぴぃ"},
     {"pyu", "ぴゅ"},
     {"pye", "ぴぇ"},
     {"pyo", "ぴょ"},
     {"ma", "ま"},
                {"mi", "み"},
     {"mu", "む"},
     {"me", "め"},
     {"mo", "も"},
     {"mya", "みゃ"},
     {"myi", "みぃ"},
     {"myu", "みゅ"},
     {"mye", "みぇ"},
                {"myo", "みょ"},
     {"ya", "や"},
     {"yu", "ゆ"},
     {"yo", "よ"},
     {"xya", "ゃ"},
     {"xyu", "ゅ"},
     {"xyo", "ょ"},
     {"ra", "ら"},
                {"ri", "り"},
     {"ru", "る"},
     {"re", "れ"},
     {"ro", "ろ"},
     {"rya", "りゃ"},
     {"ryi", "りぃ"},
     {"ryu", "りゅ"},
     {"rye", "りぇ"},
                {"ryo", "りょ"},
     {"la", "ら"},
     {"li", "り"},
     {"lu", "る"},
     {"le", "れ"},
     {"lo", "ろ"},
     {"lya", "りゃ"},
     {"lyi", "りぃ"},
                {"lyu", "りゅ"},
     {"lye", "りぇ"},
     {"lyo", "りょ"},
     {"wa", "わ"},
     {"wo", "を"},
     {"lwe", "ゎ"},
     {"xwa", "ゎ"},
     {"nn", "ん"},
                {"'n '", "ん"},
     {"xn", "ん"},
     {"ltsu", "っ"},
 {"xtsu", "っ"},

        };
    }
}
