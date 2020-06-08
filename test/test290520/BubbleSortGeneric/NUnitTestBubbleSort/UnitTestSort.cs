using System;
using System.Collections.Generic;
using BubbleSortGeneric;
using NUnit.Framework;

namespace NUnitTestBubbleSort
{
    public class Tests
    {
        static object[] SortCase =
        {
            new object[]
            {
                new List<int>() {1, 2, 3, 4, 5, 6, 7}, new List<int>() {1, 2, 3, 4, 5, 6, 7},
            },
            new object[]
            {
                new List<int>()
                    {-98502, -86595, 2409, 21381, -25829, 79291, -96127, -25722, -52972, -58877, 60671, -80516},
                new List<int>()
                    {-98502, -96127, -86595, -80516, -58877, -52972, -25829, -25722, 2409, 21381, 60671, 79291},
            },
            new object[]
            {
                new List<int>()
                {
                    35769, 58514, 48161, 84157, 83409, 22471, 61099, 61351, 50791, -26500, -52011, 44344, -91127,
                    -36937, -48340, -93654, -1051, 86980, -13174, 97878, 69256, 14097, -44657, 83648, -35031, 88357,
                    26027
                },
                new List<int>()
                {
                    -93654, -91127, -52011, -48340, -44657, -36937, -35031, -26500, -13174, -1051, 14097, 22471, 26027,
                    35769, 44344, 48161, 50791, 58514, 61099, 61351, 69256, 83409, 83648, 84157, 86980, 88357, 97878
                },
            },
            new object[]
            {
                new List<int>()
                {
                    67947, -75735, -12024, -47020, -20710, -1901, 91107, 64624, 81192, -3252, 2657, -65090, 56865,
                    69447, -12843, 30808, -56945, 2529, 36008, 7987, -39275, 12884, 77082, 28579, -83009, -98194
                },
                new List<int>()
                {
                    -98194, -83009, -75735, -65090, -56945, -47020, -39275, -20710, -12843, -12024, -3252, -1901, 2529,
                    2657, 7987, 12884, 28579, 30808, 36008, 56865, 64624, 67947, 69447, 77082, 81192, 91107
                },
            },
            new object[]
            {
                new List<int>()
                {
                    -18994, 94974, 27542, -96070, -28563, -85361, 23326, -4823, 74187, -90387, -77031, 23813, -23951,
                    66759, -89711, -62568, 95110, 79898, -28673, 28044, 72732, 19473, 64882, -92976, 5224, -74376,
                    -58081, -50269, 96279
                },
                new List<int>()
                {
                    -96070, -92976, -90387, -89711, -85361, -77031, -74376, -62568, -58081, -50269, -28673, -28563,
                    -23951, -18994, -4823, 5224, 19473, 23326, 23813, 27542, 28044, 64882, 66759, 72732, 74187, 79898,
                    94974, 95110, 96279
                },
            },
            new object[]
            {
                new List<int>()
                {
                    85579, -90250, 83254, 70937, 71324, -27202, -64001, 45109, -15711, -19000, 95257, 62868, -94146,
                    86578, 35726, 1258
                },
                new List<int>()
                {
                    -94146, -90250, -64001, -27202, -19000, -15711, 1258, 35726, 45109, 62868, 70937, 71324, 83254,
                    85579, 86578, 95257
                },
            },
            new object[]
            {
                new List<int>()
                {
                    63042, 40176, -7209, -36830, 5269, -6517, -57594, -5511, -98118, -24255, 86769, -45394, -57007,
                    43051, -41787, -73418, 12737, -80884, -57191
                },
                new List<int>()
                {
                    -98118, -80884, -73418, -57594, -57191, -57007, -45394, -41787, -36830, -24255, -7209, -6517, -5511,
                    5269, 12737, 40176, 43051, 63042, 86769
                },
            },
            new object[]
            {
                new List<int>()
                {
                    22991, 23021, -65836, -91731, 8482, -91075, -91002, 72065, 79447, 78078, -74873, 32448, -78871,
                    8687, -996, -37685, -68341, -96570, -13400, -96320, 97583, 95756, 61420, 27712, 23607, 46763, 60519
                },
                new List<int>()
                {
                    -96570, -96320, -91731, -91075, -91002, -78871, -74873, -68341, -65836, -37685, -13400, -996, 8482,
                    8687, 22991, 23021, 23607, 27712, 32448, 46763, 60519, 61420, 72065, 78078, 79447, 95756, 97583
                },
            },
            new object[]
            {
                new List<int>()
                {
                    15776, 41469, -31396, -16164, 50672, -53523, -21468, 59994, -22188, -8366, -47536, -61227, -49689,
                    -60476, 52750, 29710, 7092, -15264, -10708, 72819, -2599, 7711, 73208, 97531, 49668
                },
                new List<int>()
                {
                    -61227, -60476, -53523, -49689, -47536, -31396, -22188, -21468, -16164, -15264, -10708, -8366,
                    -2599, 7092, 7711, 15776, 29710, 41469, 49668, 50672, 52750, 59994, 72819, 73208, 97531
                },
            },
            new object[]
            {
                new List<int>()
                {
                    -70908, -53842, 42835, -39448, 72854, -64236, -72713, -18500, -57822, -27662, 89058, -91526, 27864,
                    88269, -92748
                },
                new List<int>()
                {
                    -92748, -91526, -72713, -70908, -64236, -57822, -53842, -39448, -27662, -18500, 27864, 42835, 72854,
                    88269, 89058
                },
            },
            new object[]
            {
                new List<int>() {-50095, -44047, 9291, -95597, -71583, 8416, 87468, 64703, 44913, 24075, 46850, 22995},
                new List<int>() {-95597, -71583, -50095, -44047, 8416, 9291, 22995, 24075, 44913, 46850, 64703, 87468},
            },
            new object[]
            {
                new List<int>()
                {
                    91888, -77942, 43482, -35016, 87221, 61906, -30269, 17829, -26742, 37816, -30493, 65852, 84863,
                    47373, -53648, -97463, 6319, -15238
                },
                new List<int>()
                {
                    -97463, -77942, -53648, -35016, -30493, -30269, -26742, -15238, 6319, 17829, 37816, 43482, 47373,
                    61906, 65852, 84863, 87221, 91888
                },
            },
            new object[]
            {
                new List<int>()
                {
                    -98873, -72267, 15070, -38038, -3527, -17589, -21764, -40524, 1610, -76213, 40564, 51697, -83001,
                    -79349
                },
                new List<int>()
                {
                    -98873, -83001, -79349, -76213, -72267, -40524, -38038, -21764, -17589, -3527, 1610, 15070, 40564,
                    51697
                },
            },
            new object[]
            {
                new List<int>()
                {
                    -80506, -27629, 10681, 532, 34508, -41951, -55226, -5606, -80777, -90740, -54736, -45457, 25471,
                    -32257
                },
                new List<int>()
                {
                    -90740, -80777, -80506, -55226, -54736, -45457, -41951, -32257, -27629, -5606, 532, 10681, 25471,
                    34508
                },
            },
            new object[]
            {
                new List<int>()
                {
                    -93650, -13094, 72259, -69261, 13961, 39703, -92418, -61259, -87417, 41441, -20040, -67796, 74125,
                    24093, -96836, 54493, -7510, 4835
                },
                new List<int>()
                {
                    -96836, -93650, -92418, -87417, -69261, -67796, -61259, -20040, -13094, -7510, 4835, 13961, 24093,
                    39703, 41441, 54493, 72259, 74125
                },
            },
            new object[]
            {
                new List<int>()
                {
                    -25856, 6235, -68637, 23296, -87469, -20633, -84073, 93198, 83587, -24180, -11353, -21968, -63048,
                    -51302, 63214, -32218, 93668, -7320, 93561, 47542, -79640, -23222, -34622, -36399, 60614, -93689,
                    27924, 16798, 16802, -15459
                },
                new List<int>()
                {
                    -93689, -87469, -84073, -79640, -68637, -63048, -51302, -36399, -34622, -32218, -25856, -24180,
                    -23222, -21968, -20633, -15459, -11353, -7320, 6235, 16798, 16802, 23296, 27924, 47542, 60614,
                    63214, 83587, 93198, 93561, 93668
                },
            },
            new object[]
            {
                new List<int>()
                {
                    35452, -66493, 8457, -67343, 3685, 57501, -5733, 8099, 60654, 7827, 28321, -19384, -51867, 84567,
                    -83177, -22648, -30740, -82909, -94497, -90760, 72459, -10386, 90651, 49127, 23354, -99435, -7006,
                    20857
                },
                new List<int>()
                {
                    -99435, -94497, -90760, -83177, -82909, -67343, -66493, -51867, -30740, -22648, -19384, -10386,
                    -7006, -5733, 3685, 7827, 8099, 8457, 20857, 23354, 28321, 35452, 49127, 57501, 60654, 72459, 84567,
                    90651
                },
            },
            new object[]
            {
                new List<int>()
                {
                    -59435, 47990, -57393, 62311, 97515, 47434, 25727, -36371, -33130, 34331, 70270, 67918, 50284,
                    -47602, 89614, 34228, -65178, 3903, 74566, -7712, 33991
                },
                new List<int>()
                {
                    -65178, -59435, -57393, -47602, -36371, -33130, -7712, 3903, 25727, 33991, 34228, 34331, 47434,
                    47990, 50284, 62311, 67918, 70270, 74566, 89614, 97515
                },
            },
            new object[]
            {
                new List<int>()
                {
                    7927, -83985, 77399, 25465, 50012, 46253, 91431, 55143, -65214, 71669, 40916, -40487, 24417, -47049,
                    -7624, 46782, -23336, 6098, 64648, -7786, 68430, -56458, -45128, 45380, -27384, 59921, -62710,
                    16940, 73211, -51501
                },
                new List<int>()
                {
                    -83985, -65214, -62710, -56458, -51501, -47049, -45128, -40487, -27384, -23336, -7786, -7624, 6098,
                    7927, 16940, 24417, 25465, 40916, 45380, 46253, 46782, 50012, 55143, 59921, 64648, 68430, 71669,
                    73211, 77399, 91431
                },
            },
            new object[]
            {
                new List<int>()
                {
                    -24579, 90388, 47845, 58820, 5273, -3715, -10092, -35890, 93289, -20724, 43519, 29287, 87557, -58856
                },
                new List<int>()
                {
                    -58856, -35890, -24579, -20724, -10092, -3715, 5273, 29287, 43519, 47845, 58820, 87557, 90388, 93289
                },
            },
            new object[]
            {
                new List<int>()
                {
                    79705, -80732, 48023, -54335, -15256, 60716, 73195, -54004, -39791, 94256, 71299, -50523, 91137,
                    -99234, -15156, 7978, 99840, -37481, -61335
                },
                new List<int>()
                {
                    -99234, -80732, -61335, -54335, -54004, -50523, -39791, -37481, -15256, -15156, 7978, 48023, 60716,
                    71299, 73195, 79705, 91137, 94256, 99840
                },
            },
            new object[]
            {
                new List<int>()
                {
                    69170, -47167, -98504, 54239, -83417, 78914, 7151, -78392, 62454, 98730, -6534, -69248, 5833, 81343,
                    -76308, -75338, 35640, 360, 55781, -14024, -60784, -16120, -44519, 84605, 83568, 30929, 14888,
                    -57594
                },
                new List<int>()
                {
                    -98504, -83417, -78392, -76308, -75338, -69248, -60784, -57594, -47167, -44519, -16120, -14024,
                    -6534, 360, 5833, 7151, 14888, 30929, 35640, 54239, 55781, 62454, 69170, 78914, 81343, 83568, 84605,
                    98730
                },
            },
            new object[]
            {
                new List<int>()
                {
                    31689, 31199, 56146, 32961, -6367, 9848, -42381, 69487, -4130, 62094, 40673, -34492, 57114, 11867,
                    10939, -92924
                },
                new List<int>()
                {
                    -92924, -42381, -34492, -6367, -4130, 9848, 10939, 11867, 31199, 31689, 32961, 40673, 56146, 57114,
                    62094, 69487
                },
            },
            new object[]
            {
                new List<int>()
                {
                    22130, 709, -94287, 4017, -16519, -44530, -94095, 81151, -21389, 17892, 17802, -36075, -39500,
                    57074, -67837, -44231, -19060, 90153, 58556, 3407, -7085, -65074, -87030, -98025
                },
                new List<int>()
                {
                    -98025, -94287, -94095, -87030, -67837, -65074, -44530, -44231, -39500, -36075, -21389, -19060,
                    -16519, -7085, 709, 3407, 4017, 17802, 17892, 22130, 57074, 58556, 81151, 90153
                },
            },
            new object[]
            {
                new List<int>()
                {
                    94163, -74396, 67539, 7858, 21267, -96228, 82350, 43684, -41206, 37193, -10801, -17927, 67759,
                    -88770, 61473
                },
                new List<int>()
                {
                    -96228, -88770, -74396, -41206, -17927, -10801, 7858, 21267, 37193, 43684, 61473, 67539, 67759,
                    82350, 94163
                },
            },
            new object[]
            {
                new List<int>()
                    {-17707, 5294, 39061, 14527, -45679, -95382, -50733, 98696, -69786, 96032, -24179, 48571},
                new List<int>()
                    {-95382, -69786, -50733, -45679, -24179, -17707, 5294, 14527, 39061, 48571, 96032, 98696},
            },
            new object[]
            {
                new List<int>()
                {
                    99229, -75694, 47983, -6074, -1502, 74507, 75268, -80508, 78215, -61658, -90168, 88004, 42407,
                    88796, 33481, 10621, 7446, -57199, -55082, -120, 47548, 30981, -67757, 3937, -51634, 17614, -58338,
                    -846, -72299
                },
                new List<int>()
                {
                    -90168, -80508, -75694, -72299, -67757, -61658, -58338, -57199, -55082, -51634, -6074, -1502, -846,
                    -120, 3937, 7446, 10621, 17614, 30981, 33481, 42407, 47548, 47983, 74507, 75268, 78215, 88004,
                    88796, 99229
                },
            },
            new object[]
            {
                new List<int>()
                {
                    52029, 74634, 88631, -85922, 81971, -33091, -85383, -49746, -34386, 9260, -33220, 3164, 16678,
                    88203, -77244, -77466, 42998, -56799, -97215, -25350, 54180, 70054, 18277, 81739, -63400, -55573
                },
                new List<int>()
                {
                    -97215, -85922, -85383, -77466, -77244, -63400, -56799, -55573, -49746, -34386, -33220, -33091,
                    -25350, 3164, 9260, 16678, 18277, 42998, 52029, 54180, 70054, 74634, 81739, 81971, 88203, 88631
                },
            },
            new object[]
            {
                new List<int>()
                {
                    -55727, 31906, 92764, 17850, -50782, 42357, -87889, -11488, -8841, -34937, -25639, -85022, 78697,
                    -65570, 62589, -16908, -23921, -71462, -57779, -66790, -89323, 68091, -59875, -5888, -6262, 15028
                },
                new List<int>()
                {
                    -89323, -87889, -85022, -71462, -66790, -65570, -59875, -57779, -55727, -50782, -34937, -25639,
                    -23921, -16908, -11488, -8841, -6262, -5888, 15028, 17850, 31906, 42357, 62589, 68091, 78697, 92764
                },
            },
            new object[]
            {
                new List<int>()
                {
                    48336, 48585, -18310, 17232, -77527, 92878, 19475, -66553, 77917, -89479, -93100, 60530, -93449,
                    35483, 97104, -33148, 83905, 70518, -56039, -12818, -75556
                },
                new List<int>()
                {
                    -93449, -93100, -89479, -77527, -75556, -66553, -56039, -33148, -18310, -12818, 17232, 19475, 35483,
                    48336, 48585, 60530, 70518, 77917, 83905, 92878, 97104
                },
            },
            new object[]
            {
                new List<int>()
                {
                    -48801, 72032, 40339, -97978, 43265, 67778, -74110, 34445, 10852, 25399, -30855, 56974, 44574, -7377
                },
                new List<int>()
                {
                    -97978, -74110, -48801, -30855, -7377, 10852, 25399, 34445, 40339, 43265, 44574, 56974, 67778, 72032
                },
            },
            new object[]
            {
                new List<int>()
                    {-97531, 98636, 97839, -62156, -69308, -84733, -17303, 24229, -25157, -22802, 47616, -96036, 31084},
                new List<int>()
                    {-97531, -96036, -84733, -69308, -62156, -25157, -22802, -17303, 24229, 31084, 47616, 97839, 98636},
            },
        };

        [TestCaseSource(nameof(SortCase))]
        public void Test1(List<int> unsortedList, List<int> sortedList)
        {
            var bubbleSort = new BubbleSort<int>(unsortedList, new DefaultComparer<int>());

            var result = bubbleSort.Sort();

            if (result.Count != sortedList.Count)
            {
                Assert.Fail();
            }

            for (var i = 0; i < result.Count; i++)
            {
                if (result[i] != sortedList[i])
                {
                    Assert.Fail();
                }
            }

            Assert.Pass();
        }
    }

    class DefaultComparer<T> : IComparer<T>
        where T : IComparable<T>
    {
        public int Compare(T first, T second)
        {
            return first.CompareTo(second);
        }
    }
}