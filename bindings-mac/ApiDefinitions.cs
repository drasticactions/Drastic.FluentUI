using System;
using AppKit;
using CoreGraphics;
using FluentUI;
using Foundation;
using ObjCRuntime;

namespace Drastic.FluentUI.MacOS
{
	// @interface MSFAvatarView : NSView
	[BaseType (typeof(NSView))]
	interface MSFAvatarView
	{
		// -(instancetype _Nonnull)initWithAvatarSize:(CGFloat)avatarSize contactName:(NSString * _Nullable)contactName contactEmail:(NSString * _Nullable)contactEmail contactImage:(NSImage * _Nullable)contactImage __attribute__((objc_designated_initializer));
		[Export ("initWithAvatarSize:contactName:contactEmail:contactImage:")]
		[DesignatedInitializer]
		NativeHandle Constructor (nfloat avatarSize, [NullAllowed] string contactName, [NullAllowed] string contactEmail, [NullAllowed] NSImage contactImage);

		// -(void)updateLayer;
		[Export ("updateLayer")]
		void UpdateLayer ();

		// @property (nonatomic, strong) NSColor * _Nonnull avatarBackgroundColor;
		[Export ("avatarBackgroundColor", ArgumentSemantic.Strong)]
		NSColor AvatarBackgroundColor { get; set; }

		// @property (nonatomic, strong) NSColor * _Nonnull initialsFontColor;
		[Export ("initialsFontColor", ArgumentSemantic.Strong)]
		NSColor InitialsFontColor { get; set; }

		// @property (nonatomic, strong) NSImage * _Nullable contactImage;
		[NullAllowed, Export ("contactImage", ArgumentSemantic.Strong)]
		NSImage ContactImage { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable contactName;
		[NullAllowed, Export ("contactName")]
		string ContactName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable contactEmail;
		[NullAllowed, Export ("contactEmail")]
		string ContactEmail { get; set; }

		// @property (nonatomic) CGFloat avatarSize;
		[Export ("avatarSize")]
		nfloat AvatarSize { get; set; }

		// @property (nonatomic, strong) NSColor * _Nonnull borderColor;
		[Export ("borderColor", ArgumentSemantic.Strong)]
		NSColor BorderColor { get; set; }

		// @property (nonatomic) BOOL hasBorder;
		[Export ("hasBorder")]
		bool HasBorder { get; set; }

		// @property (nonatomic) BOOL hideInsideGapForBorder;
		[Export ("hideInsideGapForBorder")]
		bool HideInsideGapForBorder { get; set; }

		// +(MSFColorSet * _Nonnull)getColorForIndex:(NSInteger)index __attribute__((warn_unused_result(""))) __attribute__((deprecated("Use getInitialsColorSetFromPrimaryText:secondaryText: instead")));
		[Static]
		[Export ("getColorForIndex:")]
		MSFColorSet GetColorForIndex (nint index);

		// +(NSInteger)colorHashForIdentifyingString:(NSString * _Nonnull)identifyingString __attribute__((warn_unused_result(""))) __attribute__((deprecated("Use getInitialsColorSetFromPrimaryText:secondaryText: instead")));
		[Static]
		[Export ("colorHashForIdentifyingString:")]
		nint ColorHashForIdentifyingString (string identifyingString);

		// +(NSColor * _Nonnull)getLegacyBackgroundColorForHash:(NSInteger)hashValue __attribute__((warn_unused_result(""))) __attribute__((deprecated("Use getInitialsColorSetFromPrimaryText:secondaryText: instead")));
		[Static]
		[Export ("getLegacyBackgroundColorForHash:")]
		NSColor GetLegacyBackgroundColorForHash (nint hashValue);

		// +(NSString * _Nullable)initialsWithName:(NSString * _Nullable)name email:(NSString * _Nullable)email __attribute__((warn_unused_result("")));
		[Static]
		[Export ("initialsWithName:email:")]
		[return: NullAllowed]
		string InitialsWithName ([NullAllowed] string name, [NullAllowed] string email);

		// +(MSFColorSet * _Nonnull)getInitialsColorSetFromPrimaryText:(NSString * _Nullable)primaryText secondaryText:(NSString * _Nullable)secondaryText __attribute__((warn_unused_result("")));
		[Static]
		[Export ("getInitialsColorSetFromPrimaryText:secondaryText:")]
		MSFColorSet GetInitialsColorSetFromPrimaryText ([NullAllowed] string primaryText, [NullAllowed] string secondaryText);

		// -(void)viewWillMoveToWindow:(NSWindow * _Nullable)newWindow;
		[Export ("viewWillMoveToWindow:")]
		void ViewWillMoveToWindow ([NullAllowed] NSWindow newWindow);
	}

	// @interface MSFBadgeView : NSView
	[BaseType (typeof(NSView))]
	interface MSFBadgeView
	{
		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title;
		[Export ("initWithTitle:")]
		NativeHandle Constructor (string title);

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title style:(enum MSFBadgeViewStyle)style __attribute__((objc_designated_initializer));
		[Export ("initWithTitle:style:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string title, MSFBadgeViewStyle style);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSCoder aDecoder);

		// -(void)updateLayer;
		[Export ("updateLayer")]
		void UpdateLayer ();

		// @property (nonatomic, strong) MSFDynamicColor * _Nonnull backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Strong)]
		MSFDynamicColor BackgroundColor { get; set; }

		// @property (nonatomic, strong) MSFDynamicColor * _Nonnull textColor;
		[Export ("textColor", ArgumentSemantic.Strong)]
		MSFDynamicColor TextColor { get; set; }
	}

	// @interface MSFButton : NSButton
	[BaseType (typeof(NSButton))]
	interface MSFButton
	{
		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title size:(enum MSFButtonSize)size style:(enum MSFButtonStyle)style accentColor:(NSColor * _Nonnull)accentColor;
		[Export ("initWithTitle:size:style:accentColor:")]
		NativeHandle Constructor (string title, MSFButtonSize size, MSFButtonStyle style, NSColor accentColor);

		// -(instancetype _Nonnull)initWithImage:(NSImage * _Nonnull)image size:(enum MSFButtonSize)size style:(enum MSFButtonStyle)style accentColor:(NSColor * _Nonnull)accentColor;
		[Export ("initWithImage:size:style:accentColor:")]
		NativeHandle Constructor (NSImage image, MSFButtonSize size, MSFButtonStyle style, NSColor accentColor);

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title image:(NSImage * _Nonnull)image imagePosition:(enum NSCellImagePosition)imagePosition size:(enum MSFButtonSize)size style:(enum MSFButtonStyle)style accentColor:(NSColor * _Nonnull)accentColor;
		[Export ("initWithTitle:image:imagePosition:size:style:accentColor:")]
		NativeHandle Constructor (string title, NSImage image, NSCellImagePosition imagePosition, MSFButtonSize size, MSFButtonStyle style, NSColor accentColor);

		// @property (nonatomic, class) Class _Nullable cellClass;
		[Static]
		[NullAllowed, Export ("cellClass", ArgumentSemantic.Assign)]
		Class CellClass { get; set; }

		// @property (nonatomic, strong) NSImage * _Nullable image;
		[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
		NSImage Image { get; set; }

		// @property (nonatomic, strong) NSImage * _Nullable trailingImage;
		[NullAllowed, Export ("trailingImage", ArgumentSemantic.Strong)]
		NSImage TrailingImage { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; set; }

		// @property (nonatomic, strong) MSFButton * _Nullable linkedPrimary;
		[NullAllowed, Export ("linkedPrimary", ArgumentSemantic.Strong)]
		MSFButton LinkedPrimary { get; set; }

		// -(void)mouseDown:(NSEvent * _Nonnull)event;
		[Export ("mouseDown:")]
		void MouseDown (NSEvent @event);

		// @property (getter = isEnabled, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		// -(void)updateLayer;
		[Export ("updateLayer")]
		void UpdateLayer ();

		// @property (readonly, nonatomic) BOOL wantsUpdateLayer;
		[Export ("wantsUpdateLayer")]
		bool WantsUpdateLayer { get; }

		// -(void)drawFocusRingMask;
		[Export ("drawFocusRingMask")]
		void DrawFocusRingMask ();

		// -(void)viewDidChangeBackingProperties;
		[Export ("viewDidChangeBackingProperties")]
		void ViewDidChangeBackingProperties ();

		// @property (nonatomic, strong) NSColor * _Nonnull accentColor;
		[Export ("accentColor", ArgumentSemantic.Strong)]
		NSColor AccentColor { get; set; }

		// @property (nonatomic) enum MSFButtonStyle style;
		[Export ("style", ArgumentSemantic.Assign)]
		MSFButtonStyle Style { get; set; }

		// @property (nonatomic) enum MSFButtonSize size;
		[Export ("size", ArgumentSemantic.Assign)]
		MSFButtonSize Size { get; set; }

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }
	}

	// @interface MSFColorSet : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MSFColorSet
	{
		// @property (readonly, nonatomic, strong) MSFDynamicColor * _Nonnull background;
		[Export ("background", ArgumentSemantic.Strong)]
		MSFDynamicColor Background { get; }

		// @property (readonly, nonatomic, strong) MSFDynamicColor * _Nonnull foreground;
		[Export ("foreground", ArgumentSemantic.Strong)]
		MSFDynamicColor Foreground { get; }
	}

	// @interface MSFColors : NSObject
	[BaseType (typeof(NSObject))]
	interface MSFColors
	{
		// +(NSColor * _Nonnull)colorFromPalette:(enum MSFColorPalette)palette __attribute__((warn_unused_result("")));
		[Static]
		[Export ("colorFromPalette:")]
		NSColor ColorFromPalette (MSFColorPalette palette);

		// @property (nonatomic, strong, class) NSColor * _Nonnull primary;
		[Static]
		[Export ("primary", ArgumentSemantic.Strong)]
		NSColor Primary { get; set; }

		// @property (nonatomic, strong, class) NSColor * _Nonnull primaryTint10;
		[Static]
		[Export ("primaryTint10", ArgumentSemantic.Strong)]
		NSColor PrimaryTint10 { get; set; }

		// @property (nonatomic, strong, class) NSColor * _Nonnull primaryTint20;
		[Static]
		[Export ("primaryTint20", ArgumentSemantic.Strong)]
		NSColor PrimaryTint20 { get; set; }

		// @property (nonatomic, strong, class) NSColor * _Nonnull primaryTint30;
		[Static]
		[Export ("primaryTint30", ArgumentSemantic.Strong)]
		NSColor PrimaryTint30 { get; set; }

		// @property (nonatomic, strong, class) NSColor * _Nonnull primaryTint40;
		[Static]
		[Export ("primaryTint40", ArgumentSemantic.Strong)]
		NSColor PrimaryTint40 { get; set; }

		// @property (nonatomic, strong, class) NSColor * _Nonnull primaryShade10;
		[Static]
		[Export ("primaryShade10", ArgumentSemantic.Strong)]
		NSColor PrimaryShade10 { get; set; }

		// @property (nonatomic, strong, class) NSColor * _Nonnull primaryShade20;
		[Static]
		[Export ("primaryShade20", ArgumentSemantic.Strong)]
		NSColor PrimaryShade20 { get; set; }

		// @property (nonatomic, strong, class) NSColor * _Nonnull primaryShade30;
		[Static]
		[Export ("primaryShade30", ArgumentSemantic.Strong)]
		NSColor PrimaryShade30 { get; set; }
	}

	// @interface MSFDatePickerController : NSViewController
	[BaseType (typeof(NSViewController))]
	interface MSFDatePickerController
	{
		// -(instancetype _Nonnull)initWithDate:(NSDate * _Nullable)date calendar:(NSCalendar * _Nullable)calendar style:(enum MSFDatePickerStyle)style __attribute__((objc_designated_initializer));
		[Export ("initWithDate:calendar:style:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] NSDate date, [NullAllowed] NSCalendar calendar, MSFDatePickerStyle style);

		// -(void)loadView;
		[Export ("loadView")]
		void LoadView ();

		// @property (copy, nonatomic) NSDate * _Nonnull date;
		[Export ("date", ArgumentSemantic.Copy)]
		NSDate Date { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MSFDatePickerControllerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MSFDatePickerControllerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) NSColor * _Nullable customSelectionColor;
		[NullAllowed, Export ("customSelectionColor", ArgumentSemantic.Strong)]
		NSColor CustomSelectionColor { get; set; }

		// @property (nonatomic) BOOL autoSelectWhenPaging;
		[Export ("autoSelectWhenPaging")]
		bool AutoSelectWhenPaging { get; set; }

		// @property (nonatomic) BOOL hasEdgePadding;
		[Export ("hasEdgePadding")]
		bool HasEdgePadding { get; set; }

		// @property (nonatomic) BOOL hasTextField;
		[Export ("hasTextField")]
		bool HasTextField { get; set; }
	}

	// @protocol MSFDatePickerControllerDelegate
	[Protocol, Model (AutoGeneratedName = true)]
	interface MSFDatePickerControllerDelegate
	{
		// @optional -(void)datePickerController:(MSFDatePickerController * _Nonnull)controller didSelectDate:(NSDate * _Nonnull)didSelectDate;
		[Export ("datePickerController:didSelectDate:")]
		void DidSelectDate (MSFDatePickerController controller, NSDate didSelectDate);
	}

	// @interface MSFDynamicColor : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MSFDynamicColor
	{
		// @property (readonly, nonatomic, strong) NSColor * _Nonnull light;
		[Export ("light", ArgumentSemantic.Strong)]
		NSColor Light { get; }

		// @property (readonly, nonatomic, strong) NSColor * _Nonnull dark;
		[Export ("dark", ArgumentSemantic.Strong)]
		NSColor Dark { get; }

		// -(NSColor * _Nonnull)resolvedColor:(NSAppearance * _Nullable)appearance __attribute__((warn_unused_result("")));
		[Export ("resolvedColor:")]
		NSColor ResolvedColor ([NullAllowed] NSAppearance appearance);

		// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
		[Export ("isEqual:")]
		bool IsEqual ([NullAllowed] NSObject @object);
	}

	// @interface MSFFilledTemplateImageView : NSImageView
	[BaseType (typeof(NSImageView))]
	interface MSFFilledTemplateImageView
	{
		// -(instancetype _Nonnull)initWithImage:(NSImage * _Nonnull)image fillMask:(NSImage * _Nonnull)fillMask contentTintColor:(NSColor * _Nonnull)contentTintColor fillColor:(NSColor * _Nullable)fillColor __attribute__((objc_designated_initializer));
		[Export ("initWithImage:fillMask:contentTintColor:fillColor:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSImage image, NSImage fillMask, NSColor contentTintColor, [NullAllowed] NSColor fillColor);

		// @property (nonatomic, strong) NSImage * _Nonnull fillMask;
		[Export ("fillMask", ArgumentSemantic.Strong)]
		NSImage FillMask { get; set; }

		// @property (nonatomic, strong) NSColor * _Nullable fillColor;
		[NullAllowed, Export ("fillColor", ArgumentSemantic.Strong)]
		NSColor FillColor { get; set; }

		// -(void)drawRect:(NSRect)dirtyRect;
		[Export ("drawRect:")]
		void DrawRect (CGRect dirtyRect);
	}

	// @interface FluentUIResources : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC8FluentUI17FluentUIResources")]
	interface FluentUIResources
	{
		// @property (readonly, nonatomic, strong, class) NSBundle * _Nonnull resourceBundle;
		[Static]
		[Export ("resourceBundle", ArgumentSemantic.Strong)]
		NSBundle ResourceBundle { get; }

		// @property (readonly, nonatomic, strong, class) NSBundle * _Nonnull colorsBundle;
		[Static]
		[Export ("colorsBundle", ArgumentSemantic.Strong)]
		NSBundle ColorsBundle { get; }
	}

	// @interface MSFLink : NSButton
	[BaseType (typeof(NSButton))]
	interface MSFLink
	{
		// @property (copy, nonatomic) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; set; }

		// -(void)mouseEntered:(NSEvent * _Nonnull)event;
		[Export ("mouseEntered:")]
		void MouseEntered (NSEvent @event);

		// -(void)mouseExited:(NSEvent * _Nonnull)event;
		[Export ("mouseExited:")]
		void MouseExited (NSEvent @event);

		// @property (getter = isEnabled, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		// -(void)resetCursorRects;
		[Export ("resetCursorRects")]
		void ResetCursorRects ();

		// -(void)drawFocusRingMask;
		[Export ("drawFocusRingMask")]
		void DrawFocusRingMask ();

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title url:(NSURL * _Nonnull)url;
		[Export ("initWithTitle:url:")]
		NativeHandle Constructor (string title, NSUrl url);

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title;
		[Export ("initWithTitle:")]
		NativeHandle Constructor (string title);

		// -(instancetype _Nonnull)initWithFrame:(NSRect)frameRect;
		[Export ("initWithFrame:")]
		NativeHandle Constructor (CGRect frameRect);

		// @property (copy, nonatomic) NSURL * _Nullable url;
		[NullAllowed, Export ("url", ArgumentSemantic.Copy)]
		NSUrl Url { get; set; }

		// @property (nonatomic) BOOL showsUnderlineWhileMouseInside;
		[Export ("showsUnderlineWhileMouseInside")]
		bool ShowsUnderlineWhileMouseInside { get; set; }

		// -(void)updateTrackingAreas;
		[Export ("updateTrackingAreas")]
		void UpdateTrackingAreas ();
	}

	// @protocol MSFNotificationState <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol (Name = "_TtP8FluentUI20MSFNotificationState_")]
	[BaseType (typeof(NSObject), Name = "_TtP8FluentUI20MSFNotificationState_")]
	interface MSFNotificationState
	{
		// @required @property (nonatomic) enum MSFNotificationStyle style;
		[Abstract]
		[Export ("style", ArgumentSemantic.Assign)]
		MSFNotificationStyle Style { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable message;
		[Abstract]
		[NullAllowed, Export ("message")]
		string Message { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable actionButtonTitle;
		[Abstract]
		[NullAllowed, Export ("actionButtonTitle")]
		string ActionButtonTitle { get; set; }

		// @required @property (copy, nonatomic) void (^ _Nullable)(void) actionButtonAction;
		[Abstract]
		[NullAllowed, Export ("actionButtonAction", ArgumentSemantic.Copy)]
		Action ActionButtonAction { get; set; }

		// @required @property (copy, nonatomic) void (^ _Nullable)(void) messageButtonAction;
		[Abstract]
		[NullAllowed, Export ("messageButtonAction", ArgumentSemantic.Copy)]
		Action MessageButtonAction { get; set; }

		// @required @property (nonatomic) enum MSFNotificationDirection notificationDirection;
		[Abstract]
		[Export ("notificationDirection", ArgumentSemantic.Assign)]
		MSFNotificationDirection NotificationDirection { get; set; }
	}

	// @interface MSFSeparator : NSView
	[BaseType (typeof(NSView))]
	interface MSFSeparator
	{
		// -(instancetype _Nonnull)initWithOrientation:(enum MSFSeparatorOrientation)orientation __attribute__((objc_designated_initializer));
		[Export ("initWithOrientation:")]
		[DesignatedInitializer]
		NativeHandle Constructor (MSFSeparatorOrientation orientation);

		// @property (readonly, nonatomic) BOOL wantsUpdateLayer;
		[Export ("wantsUpdateLayer")]
		bool WantsUpdateLayer { get; }

		// -(void)updateLayer;
		[Export ("updateLayer")]
		void UpdateLayer ();

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }
	}
}
