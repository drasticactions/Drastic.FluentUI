using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentUI.Controls
{
    partial class PopupMenuItem
    {
        partial class CREATOR : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class ListSubHeaderView
    {

    }

    partial class ListItemView
    {

    }

    partial class ContextualCommandBar
    {
        partial class DismissCommandItem : global::FluentUI.Controls.ICommandItem
        {
            public string? ContentDescription => throw new NotImplementedException();

            public int Icon => throw new NotImplementedException();
        }
    }

    partial class DefaultCommandItem : global::FluentUI.Controls.ICommandItem
    {
        public string? ContentDescription => throw new NotImplementedException();

        public int Icon => throw new NotImplementedException();

        public ICharSequence? LabelFormatted => throw new NotImplementedException();

        public View? View { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

namespace FluentUI.Util
{
    partial class ColorProperty : global::FluentUI.Util.FloatProperty
    {
        public override Java.Lang.Object? Get(Java.Lang.Object? @object)
        {
            throw new NotImplementedException();
        }

        public override void SetValue(Java.Lang.Object? @object, float value)
        {
            throw new NotImplementedException();
        }
    }
}

namespace FluentUI.Token
{
    partial class AliasTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size);
            }
        }
    }

    partial class Person
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size);
            }
        }
    }

    partial class Group
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size);
            }
        }
    }


    partial class GlobalTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size);
            }
        }
    }
}

namespace FluentUI.Token.ControlToken
{
    partial class ContextualCommandBarTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class DividerTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class FABTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class LinearProgressIndicatorTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class ListItemTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class TabBarTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class TabItemTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class PersonaChipTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class PillBarTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class PillTabsTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class SearchBarTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class PillSwitchTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class DrawerTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class RadioButtonTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class ToggleSwitchTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class ShimmerTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class SearchBarPersonaChipTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class ActivityRingsToken
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }


    partial class AppBarTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class AvatarCarouselTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class AvatarGroupTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class AvatarTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class BadgeTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class BottomSheetTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class ButtonTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class CheckBoxTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class CircularProgressIndicatorTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }

    partial class PillButtonTokens
    {
        partial class Creator : global::Android.OS.IParcelableCreator
        {
            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
            {
                return CreateFromParcel(source);
            }

            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
            {
                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
            }
        }
    }
}

//namespace Com.Microsoft.Fluentui.Util
//{
//    partial class ColorProperty : global::Com.Microsoft.Fluentui.Util.FloatProperty
//    {
//        public override Java.Lang.Object? Get(Java.Lang.Object? @object)
//        {
//            throw new NotImplementedException();
//        }

//        public override void SetValue(Java.Lang.Object? @object, float value)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}

//namespace Com.Microsoft.Fluentui.Theme.Token
//{
//    partial class GlobalTokens
//    {
//        partial class Creator : global::Android.OS.IParcelableCreator
//        {
//            Java.Lang.Object? IParcelableCreator.CreateFromParcel(Parcel? source)
//            {
//                return CreateFromParcel(source);
//            }

//            Java.Lang.Object[]? IParcelableCreator.NewArray(int size)
//            {
//                return NewArray(size).Cast<Java.Lang.Object>().ToArray();
//            }
//        }
//    }
//}