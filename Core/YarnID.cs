using Terraria.ModLoader;

namespace TextilesAndCo.Core
{
    public class YarnID
    {
        public const string type = "Yarn";

        private static int _black = -1;
        public static int Black
        {
            get
            {
                if (_black == -1)
                {
                    _black = TextilesAndCo.Instance.Find<ModItem>("Black" + type).Type;
                    return _black;
                }

                return _black;
            }
        }

        private static int _blue = -1;
        public static int Blue
        {
            get
            {
                if (_blue == -1)
                {
                    _blue = TextilesAndCo.Instance.Find<ModItem>("Blue" + type).Type;
                    return _blue;
                }

                return _blue;
            }
        }

        private static int _brown = -1;
        public static int Brown
        {
            get
            {
                if (_brown == -1)
                {
                    _brown = TextilesAndCo.Instance.Find<ModItem>("Brown" + type).Type;
                    return _brown;
                }

                return _brown;
            }
        }

        private static int _cyan = -1;
        public static int Cyan
        {
            get
            {
                if (_cyan == -1)
                {
                    _cyan = TextilesAndCo.Instance.Find<ModItem>("Cyan" + type).Type;
                    return _cyan;
                }

                return _cyan;
            }
        }

        private static int _green = -1;
        public static int Green
        {
            get
            {
                if (_green == -1)
                {
                    _green = TextilesAndCo.Instance.Find<ModItem>("Green" + type).Type;
                    return _green;
                }

                return _green;
            }
        }

        private static int _lime = -1;
        public static int Lime
        {
            get
            {
                if (_lime == -1)
                {
                    _lime = TextilesAndCo.Instance.Find<ModItem>("Lime" + type).Type;
                    return _lime;
                }

                return _lime;
            }
        }

        private static int _orange = -1;
        public static int Orange
        {
            get
            {
                if (_orange == -1)
                {
                    _orange = TextilesAndCo.Instance.Find<ModItem>("Orange" + type).Type;
                    return _orange;
                }

                return _orange;
            }
        }

        private static int _pink = -1;
        public static int Pink
        {
            get
            {
                if (_pink == -1)
                {
                    _pink = TextilesAndCo.Instance.Find<ModItem>("Pink" + type).Type;
                    return _pink;
                }

                return _pink;
            }
        }

        private static int _purple = -1;
        public static int Purple
        {
            get
            {
                if (_purple == -1)
                {
                    _purple = TextilesAndCo.Instance.Find<ModItem>("Purple" + type).Type;
                    return _purple;
                }

                return _purple;
            }
        }

        private static int _red = -1;
        public static int Red
        {
            get
            {
                if (_red == -1)
                {
                    _red = TextilesAndCo.Instance.Find<ModItem>("Red" + type).Type;
                    return _red;
                }

                return _red;
            }
        }

        private static int _skyBlue = -1;
        public static int SkyBlue
        {
            get
            {
                if (_skyBlue == -1)
                {
                    _skyBlue = TextilesAndCo.Instance.Find<ModItem>("SkyBlue" + type).Type;
                    return _skyBlue;
                }

                return _skyBlue;
            }
        }

        private static int _teal = -1;
        public static int Teal
        {
            get
            {
                if (_teal == -1)
                {
                    _teal = TextilesAndCo.Instance.Find<ModItem>("Teal" + type).Type;
                    return _teal;
                }

                return _teal;
            }
        }

        private static int _violet = -1;
        public static int Violet
        {
            get
            {
                if (_violet == -1)
                {
                    _violet = TextilesAndCo.Instance.Find<ModItem>("Violet" + type).Type;
                    return _violet;
                }

                return _violet;
            }
        }

        private static int _white = -1;
        public static int White
        {
            get
            {
                if (_white == -1)
                {
                    _white = TextilesAndCo.Instance.Find<ModItem>("White" + type).Type;
                    return _white;
                }

                return _white;
            }
        }

        private static int _yellow = -1;
        public static int Yellow
        {
            get
            {
                if (_yellow == -1)
                {
                    _yellow = TextilesAndCo.Instance.Find<ModItem>("Yellow" + type).Type;
                    return _yellow;
                }

                return _yellow;
            }
        }
    }
}
