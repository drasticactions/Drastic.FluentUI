using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace Drastic.FluentUI
{
[Native]
	public enum MSFActionsCellActionType : long
	{
		Regular = 0,
		Destructive = 1,
		Communication = 2
	}

	[Native]
	public enum MSFBadgeViewStyle : long
	{
		Default = 0,
		Warning = 1,
		Error = 2
	}

	[Native]
	public enum MSFBadgeViewSize : long
	{
		Small = 0,
		Medium = 1
	}

	[Native]
	public enum MSFTableViewCellSeparatorType : long
	{
		None = 0,
		Inset = 1,
		Full = 2
	}

	[Native]
	public enum BottomCommandingInteraction : long
	{
		NoUserAction = 0,
		OtherUserAction = 1,
		SheetInteraction = 2,
		MoreButtonTap = 3,
		CommandTap = 4
	}

	[Native]
	public enum BottomSheetExpansionState : long
	{
		Expanded = 0,
		Collapsed = 1,
		Hidden = 2,
		Transitioning = 3
	}

	[Native]
	public enum BottomSheetInteraction : long
	{
		NoUserAction = 0,
		Swipe = 1,
		ResizingHandleTap = 2,
		DimmingViewTap = 3
	}

	[Native]
	public enum MSFButtonStyle : long
	{
		PrimaryFilled = 0,
		PrimaryOutline = 1,
		DangerFilled = 2,
		DangerOutline = 3,
		SecondaryOutline = 4,
		TertiaryOutline = 5,
		Borderless = 6
	}

	[Native]
	public enum MSFCardColorStyle : long
	{
		AppColor = 0,
		Neutral = 1,
		Custom = 2
	}

	[Native]
	public enum MSFCardSize : long
	{
		Small = 0,
		Large = 1
	}

	[Native]
	public enum MSFColorPalette : long
	{
		AnchorShade30 = 0,
		AnchorTint40 = 1,
		BeigeShade30 = 2,
		BeigeTint40 = 3,
		BlueShade30 = 4,
		BlueTint40 = 5,
		BrassShade30 = 6,
		BrassTint40 = 7,
		BrownShade30 = 8,
		BrownTint40 = 9,
		CornFlowerShade30 = 10,
		CornFlowerTint40 = 11,
		CranberryShade30 = 12,
		CranberryTint40 = 13,
		DarkGreenShade30 = 14,
		DarkGreenTint40 = 15,
		DarkRedShade30 = 16,
		DarkRedTint40 = 17,
		ForestShade30 = 18,
		ForestTint40 = 19,
		GoldShade30 = 20,
		GoldTint40 = 21,
		GrapeShade30 = 22,
		GrapeTint40 = 23,
		LavenderShade30 = 24,
		LavenderTint40 = 25,
		LightTealShade30 = 26,
		LightTealTint40 = 27,
		LilacShade30 = 28,
		LilacTint40 = 29,
		MagentaShade30 = 30,
		MagentaTint40 = 31,
		MarigoldShade30 = 32,
		MarigoldTint40 = 33,
		MinkShade30 = 34,
		MinkTint40 = 35,
		NavyShade30 = 36,
		NavyTint40 = 37,
		PeachShade30 = 38,
		PeachTint40 = 39,
		PinkShade30 = 40,
		PinkTint40 = 41,
		PlatinumShade30 = 42,
		PlatinumTint40 = 43,
		PlumShade30 = 44,
		PlumTint40 = 45,
		PumpkinShade30 = 46,
		PumpkinTint40 = 47,
		PurpleShade30 = 48,
		PurpleTint40 = 49,
		RedShade30 = 50,
		RedTint40 = 51,
		RoyalBlueShade30 = 52,
		RoyalBlueTint40 = 53,
		SeafoamShade30 = 54,
		SeafoamTint40 = 55,
		SteelShade30 = 56,
		SteelTint40 = 57,
		TealShade30 = 58,
		TealTint40 = 59,
		PinkRed10 = 60,
		Red20 = 61,
		Red10 = 62,
		Orange30 = 63,
		Orange20 = 64,
		OrangeYellow20 = 65,
		Green20 = 66,
		Green10 = 67,
		Cyan30 = 68,
		Cyan20 = 69,
		CyanBlue20 = 70,
		CyanBlue10 = 71,
		Blue10 = 72,
		BlueMagenta30 = 73,
		BlueMagenta20 = 74,
		Magenta20 = 75,
		Magenta10 = 76,
		MagentaPink10 = 77,
		Gray40 = 78,
		Gray30 = 79,
		Gray20 = 80,
		Gray25 = 81,
		Gray50 = 82,
		Gray100 = 83,
		Gray200 = 84,
		Gray300 = 85,
		Gray400 = 86,
		Gray500 = 87,
		Gray600 = 88,
		Gray700 = 89,
		Gray800 = 90,
		Gray900 = 91,
		Gray950 = 92,
		CommunicationBlue = 93,
		CommunicationBlueTint40 = 94,
		CommunicationBlueTint30 = 95,
		CommunicationBlueTint20 = 96,
		CommunicationBlueTint10 = 97,
		CommunicationBlueShade30 = 98,
		CommunicationBlueShade20 = 99,
		CommunicationBlueShade10 = 100,
		DangerPrimary = 101,
		DangerTint40 = 102,
		DangerTint30 = 103,
		DangerTint20 = 104,
		DangerTint10 = 105,
		DangerShade30 = 106,
		DangerShade20 = 107,
		DangerShade10 = 108,
		WarningPrimary = 109,
		WarningTint40 = 110,
		WarningTint30 = 111,
		WarningTint20 = 112,
		WarningTint10 = 113,
		WarningShade30 = 114,
		WarningShade20 = 115,
		WarningShade10 = 116,
		SuccessPrimary = 117,
		SuccessTint40 = 118,
		SuccessTint30 = 119,
		SuccessTint20 = 120,
		SuccessTint10 = 121,
		SuccessShade30 = 122,
		SuccessShade20 = 123,
		SuccessShade10 = 124,
		PresenceAvailable = 125,
		PresenceAway = 126,
		PresenceBlocked = 127,
		PresenceBusy = 128,
		PresenceDnd = 129,
		PresenceOffline = 130,
		PresenceOof = 131,
		PresenceUnknown = 132
	}

	[Native]
	public enum MSFDateStringCompactness : long
	{
		LongDaynameDayMonth = 1,
		LongDaynameDayMonthYear = 2,
		ShortDayname = 3,
		ShortDaynameShortMonthnameDay = 4,
		ShortDaynameShortMonthnameDayFullYear = 5,
		PartialDaynameShortDayMonth = 6,
		LongDaynameDayMonthHoursColumnsMinutes = 7,
		ShortDaynameShortMonthnameHoursColumnsMinutes = 8,
		PartialDaynameShortDayMonthHoursColumsMinutes = 9,
		PartialMonthnameDaynameFullYear = 10,
		PartialMonthnameDaynameHoursColumnsMinutes = 11,
		PartialMonthnameDayname = 12,
		LongMonthNameFullYear = 13,
		ShortDaynameHoursColumnMinutes = 14,
		ShortDayMonth = 15,
		LongDayMonthYearTime = 16,
		ShortDaynameDayShortMonthYear = 17
	}

	[Native]
	public enum MSFDateTimePickerDatePickerType : long
	{
		alendar = 0,
		omponents = 1
	}

	[Native]
	public enum MSFDateTimePickerDateRangePresentation : long
	{
		Paged = 0,
		Tabbed = 1
	}

	[Native]
	public enum MSFDateTimePickerMode : long
	{
		MSFDateTimePickerModeDate = 0,
		Time = 1,
		Range = 2,
		TimeRange = 3
	}

	[Native]
	public enum MSFDayOfWeek : long
	{
		Sunday = 0,
		Monday = 1,
		Tuesday = 2,
		Wednesday = 3,
		Thursday = 4,
		Friday = 5,
		Saturday = 6
	}

	[Native]
	public enum MSFDimmingViewType : long
	{
		White = 1,
		Black = 2,
		None = 3
	}

	[Native]
	public enum MSFDrawerPresentationBackground : long
	{
		None = 0,
		Black = 1
	}

	[Native]
	public enum MSFDrawerPresentationDirection : long
	{
		Down = 0,
		Up = 1,
		FromLeading = 2,
		FromTrailing = 3
	}

	[Native]
	public enum MSFDrawerPresentationStyle : long
	{
		Automatic = -1,
		Slideover = 0,
		Popover = 1
	}

	[Native]
	public enum MSFDrawerResizingBehavior : long
	{
		None = 0,
		Dismiss = 1,
		Expand = 2,
		DismissOrExpand = 3
	}

	[Native]
	public enum MSFPopupMenuItemExecutionMode : long
	{
		OnSelection = 0,
		OnSelectionWithoutDismissal = 1,
		AfterPopupMenuDismissal = 2,
		AfterPopupMenuDismissalCompleted = 3
	}

	[Native]
	public enum MSFNeutralColorsToken : long
	{
		Black = 0,
		Grey2 = 1,
		Grey4 = 2,
		Grey6 = 3,
		Grey8 = 4,
		Grey10 = 5,
		Grey12 = 6,
		Grey14 = 7,
		Grey16 = 8,
		Grey18 = 9,
		Grey20 = 10,
		Grey22 = 11,
		Grey24 = 12,
		Grey26 = 13,
		Grey28 = 14,
		Grey30 = 15,
		Grey32 = 16,
		Grey34 = 17,
		Grey36 = 18,
		Grey38 = 19,
		Grey40 = 20,
		Grey42 = 21,
		Grey44 = 22,
		Grey46 = 23,
		Grey48 = 24,
		Grey50 = 25,
		Grey52 = 26,
		Grey54 = 27,
		Grey56 = 28,
		Grey58 = 29,
		Grey60 = 30,
		Grey62 = 31,
		Grey64 = 32,
		Grey66 = 33,
		Grey68 = 34,
		Grey70 = 35,
		Grey72 = 36,
		Grey74 = 37,
		Grey76 = 38,
		Grey78 = 39,
		Grey80 = 40,
		Grey82 = 41,
		Grey84 = 42,
		Grey86 = 43,
		Grey88 = 44,
		Grey90 = 45,
		Grey92 = 46,
		Grey94 = 47,
		Grey96 = 48,
		Grey98 = 49,
		White = 50
	}

	[Native]
	public enum MSFSharedColorSets : long
	{
		DarkRed = 0,
		Burgundy = 1,
		Cranberry = 2,
		Red = 3,
		DarkOrange = 4,
		Bronze = 5,
		Pumpkin = 6,
		Orange = 7,
		Peach = 8,
		Marigold = 9,
		Yellow = 10,
		Gold = 11,
		Brass = 12,
		Brown = 13,
		DarkBrown = 14,
		Lime = 15,
		Forest = 16,
		Seafoam = 17,
		LightGreen = 18,
		Green = 19,
		DarkGreen = 20,
		LightTeal = 21,
		Teal = 22,
		DarkTeal = 23,
		Cyan = 24,
		Steel = 25,
		LightBlue = 26,
		Blue = 27,
		RoyalBlue = 28,
		DarkBlue = 29,
		Cornflower = 30,
		Navy = 31,
		Lavender = 32,
		Purple = 33,
		DarkPurple = 34,
		Orchid = 35,
		Grape = 36,
		Berry = 37,
		Lilac = 38,
		Pink = 39,
		HotPink = 40,
		Magenta = 41,
		Plum = 42,
		Beige = 43,
		Mink = 44,
		Silver = 45,
		Platinum = 46,
		Anchor = 47,
		Charcoal = 48
	}

	[Native]
	public enum MSFSharedColorsTokens : long
	{
		Shade50 = 0,
		Shade40 = 1,
		Shade30 = 2,
		Shade20 = 3,
		Shade10 = 4,
		Primary = 5,
		Tint10 = 6,
		Tint20 = 7,
		Tint30 = 8,
		Tint40 = 9,
		Tint50 = 10,
		Tint60 = 11
	}

	[Native]
	public enum MSFActivityIndicatorSize : long
	{
		XSmall = 0,
		Small = 1,
		Medium = 2,
		Large = 3,
		XLarge = 4
	}

	[Native]
	public enum MSFAvatarGroupStyle : long
	{
		Stack = 0,
		Pile = 1
	}

	[Native]
	public enum MSFAvatarPresence : long
	{
		None = 0,
		Available = 1,
		Away = 2,
		Blocked = 3,
		Busy = 4,
		DoNotDisturb = 5,
		Offline = 6,
		Unknown = 7
	}

	[Native]
	public enum MSFAvatarSize : long
	{
		MSFAvatarSizeSize16 = 0,
		MSFAvatarSizeSize20 = 1,
		MSFAvatarSizeSize24 = 2,
		MSFAvatarSizeSize32 = 3,
		MSFAvatarSizeSize40 = 4,
		MSFAvatarSizeSize56 = 5,
		MSFAvatarSizeSize72 = 6
	}

	[Native]
	public enum MSFAvatarStyle : long
	{
		Default = 0,
		Accent = 1,
		Group = 2,
		Outlined = 3,
		OutlinedPrimary = 4,
		Overflow = 5
	}

	[Native]
	public enum MSFCardNudgeStyle : long
	{
		Standard = 0,
		Outline = 1
	}

	[Native]
	public enum MSFDividerOrientation : long
	{
		Horizontal = 0,
		Vertical = 1
	}

	[Native]
	public enum MSFDividerSpacing : long
	{
		None = 0,
		Medium = 1
	}

	[Native]
	public enum MSFNotificationStyle : long
	{
		PrimaryToast = 0,
		NeutralToast = 1,
		PrimaryBar = 2,
		PrimaryOutlineBar = 3,
		NeutralBar = 4,
		DangerToast = 5,
		WarningToast = 6
	}

	[Native]
	public enum MSFPersonaButtonSize : long
	{
		Small = 0,
		Large = 1
	}

	[Native]
	public enum MSFShimmerStyle : long
	{
		Concealing = 0,
		Revealing = 1
	}

	[Native]
	public enum MSFTableViewCellCustomViewSize : long
	{
		Default = 0,
		Zero = 1,
		Small = 2,
		Medium = 3
	}

	[Native]
	public enum MSFNavigationBarStyle : long
	{
		Default = 0,
		Primary = 1,
		System = 2,
		Custom = 3
	}

	[Native]
	public enum MSFNavigationBarElementSize : long
	{
		Automatic = 0,
		Contracted = 1,
		Expanded = 2
	}

	[Native]
	public enum MSFNavigationBarShadow : long
	{
		utomatic = 0,
		lwaysHidden = 1
	}

	[Native]
	public enum MSFObscureStyle : long
	{
		Blur = 0,
		Dim = 1
	}

	[Native]
	public enum MSFPersonaListViewSelectionDirection : long
	{
		Next = 1,
		Prev = -1
	}

	[Native]
	public enum MSFPillButtonStyle : long
	{
		Primary = 0,
		OnBrand = 1
	}

	[Native]
	public enum MSFSearchBarStyle : long
	{
		LightContent = 0,
		DarkContent = 1
	}

	[Native]
	public enum MSFSegmentedControlStyle : long
	{
		PrimaryPill = 0,
		OnBrandPill = 1
	}

	[Native]
	public enum MSFTableViewCellAccessoryType : long
	{
		None = 0,
		DisclosureIndicator = 1,
		DetailButton = 2,
		Checkmark = 3
	}

	[Native]
	public enum MSFTableViewCellBackgroundStyleType : long
	{
		Plain = 0,
		Grouped = 1,
		Clear = 2,
		Custom = 3
	}

	[Native]
	public enum MSFTableViewHeaderFooterViewAccessoryButtonStyle : long
	{
		Regular = 0,
		Primary = 1
	}

	[Native]
	public enum MSFTableViewHeaderFooterViewStyle : long
	{
		Header = 0,
		Divider = 1,
		DividerHighlighted = 2,
		Footer = 3,
		HeaderPrimary = 4
	}

	[Native]
	public enum MSFTextColorStyle : long
	{
		Regular = 0,
		Secondary = 1,
		White = 2,
		Primary = 3,
		Error = 4,
		Warning = 5,
		Disabled = 6
	}

	[Native]
	public enum MSFTextStyle : long
	{
		LargeTitle = 0,
		Title1 = 1,
		Title2 = 2,
		Headline = 3,
		Body = 4,
		Subhead = 5,
		Footnote = 6,
		Button1 = 7,
		Button2 = 8,
		Caption1 = 9,
		Caption2 = 10
	}

	[Native]
	public enum MSFTimeStringCompactness : long
	{
		ColumnsMinutes = 1,
		MSFTimeStringCompactnessHours = 2
	}

	[Native]
	public enum MSFTooltipArrowDirection : long
	{
		Up = 0,
		Down = 1,
		Left = 2,
		Right = 3
	}

	[Native]
	public enum MSFTooltipDismissMode : long
	{
		Anywhere = 0,
		OnTooltip = 1,
		OnTooltipOrAnchor = 2
	}

	[Native]
	public enum MSFTwoLineTitleViewStyle : long
	{
		Light = 0,
		Dark = 1
	}

	[Native]
	public enum MSFTwoLineTitleViewInteractivePart : long
	{
		None = 0,
		Title = 1,
		Subtitle = 2
	}

	[Native]
	public enum MSFTwoLineTitleViewAccessoryType : long
	{
		None = 0,
		Disclosure = 1,
		DownArrow = 2
	}

	[Native]
	public enum MSFWeekOfMonth : long
	{
		First = 1,
		Second = 2,
		Third = 3,
		Fourth = 4,
		Last = 5
	}
}