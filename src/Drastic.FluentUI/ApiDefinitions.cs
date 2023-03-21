using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using NSLineBreakMode = global::UIKit.UILineBreakMode;
using NSTextAlignment = global::UIKit.UITextAlignment;
namespace FluentUI
{

// @protocol AccessibleViewDelegate
	[Protocol (Name = "_TtP8FluentUI22AccessibleViewDelegate_"), Model]
    [BaseType (typeof(NSObject))]
	interface AccessibleViewDelegate
	{
		// @optional -(NSString * _Nullable)accessibilityValueForAccessibleView:(UIView * _Nonnull)accessibleView __attribute__((warn_unused_result("")));
		[Export ("accessibilityValueForAccessibleView:")]
		[return: NullAllowed]
		string AccessibilityValueForAccessibleView (UIView accessibleView);

		// @optional -(NSString * _Nullable)accessibilityLabelForAccessibleView:(UIView * _Nonnull)accessibleView __attribute__((warn_unused_result("")));
		[Export ("accessibilityLabelForAccessibleView:")]
		[return: NullAllowed]
		string AccessibilityLabelForAccessibleView (UIView accessibleView);

		// @optional -(BOOL)accessibilityActivateForAccessibleView:(UIView * _Nonnull)accessibleView __attribute__((warn_unused_result("")));
		[Export ("accessibilityActivateForAccessibleView:")]
		bool AccessibilityActivateForAccessibleView (UIView accessibleView);

		// @optional -(void)accessibilityIncrementForAccessibleView:(UIView * _Nonnull)accessibleView;
		[Export ("accessibilityIncrementForAccessibleView:")]
		void AccessibilityIncrementForAccessibleView (UIView accessibleView);

		// @optional -(void)accessibilityDecrementForAccessibleView:(UIView * _Nonnull)accessibleView;
		[Export ("accessibilityDecrementForAccessibleView:")]
		void AccessibilityDecrementForAccessibleView (UIView accessibleView);

		// @optional -(BOOL)accessibilityPerformMagicTapForAccessibleView:(UIView * _Nonnull)accessibleView __attribute__((warn_unused_result("")));
		[Export ("accessibilityPerformMagicTapForAccessibleView:")]
		bool AccessibilityPerformMagicTapForAccessibleView (UIView accessibleView);

		// @optional -(NSArray * _Nullable)accessibilityElementsForAccessibleView:(UIView * _Nonnull)accessibleView __attribute__((warn_unused_result("")));
		[Export ("accessibilityElementsForAccessibleView:")]
		//[Verify (StronglyTypedNSArray)]
		[return: NullAllowed]
		NSObject[] AccessibilityElementsForAccessibleView (UIView accessibleView);
	}

	// // @protocol AccessibleTableViewDelegate <AccessibleViewDelegate>
	// [Protocol (Name = "_TtP8FluentUI27AccessibleTableViewDelegate_"), Model]
	// [BaseType (typeof(NSObject))]
    // interface AccessibleTableViewDelegate : IAccessibleViewDelegate
	// {
	// 	// @optional -(NSString * _Nullable)accessibilityValueForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath forTableView:(UITableView * _Nonnull)forTableView __attribute__((warn_unused_result("")));
	// 	[Export ("accessibilityValueForRowAtIndexPath:forTableView:")]
	// 	[return: NullAllowed]
	// 	string ForTableView (NSIndexPath indexPath, UITableView forTableView);
	// }

	// @interface MSFActionsCell : UITableViewCell
	[BaseType (typeof(UITableViewCell))]
	interface MSFActionsCell
	{
		// @property (nonatomic) enum MSFTableViewCellSeparatorType topSeparatorType;
		[Export ("topSeparatorType", ArgumentSemantic.Assign)]
		MSFTableViewCellSeparatorType TopSeparatorType { get; set; }

		// @property (nonatomic) enum MSFTableViewCellSeparatorType bottomSeparatorType;
		[Export ("bottomSeparatorType", ArgumentSemantic.Assign)]
		MSFTableViewCellSeparatorType BottomSeparatorType { get; set; }

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// @property (nonatomic) enum MSFTableViewCellBackgroundStyleType backgroundStyleType;
		[Export ("backgroundStyleType", ArgumentSemantic.Assign)]
		MSFTableViewCellBackgroundStyleType BackgroundStyleType { get; set; }

		// @property (readonly, nonatomic, strong) UIButton * _Nonnull action1Button;
		[Export ("action1Button", ArgumentSemantic.Strong)]
		UIButton Action1Button { get; }

		// @property (readonly, nonatomic, strong) UIButton * _Nonnull action2Button;
		[Export ("action2Button", ArgumentSemantic.Strong)]
		UIButton Action2Button { get; }

		// -(instancetype _Nonnull)initWithStyle:(UITableViewCellStyle)style reuseIdentifier:(NSString * _Nullable)reuseIdentifier __attribute__((objc_designated_initializer));
		[Export ("initWithStyle:reuseIdentifier:")]
		[DesignatedInitializer]
		NativeHandle Constructor (UITableViewCellStyle style, [NullAllowed] string reuseIdentifier);

		// // -(instancetype _Nonnull)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// -(void)setupWithAction1Title:(NSString * _Nonnull)action1Title action2Title:(NSString * _Nonnull)action2Title action1Type:(enum MSFActionsCellActionType)action1Type action2Type:(enum MSFActionsCellActionType)action2Type;
		[Export ("setupWithAction1Title:action2Title:action1Type:action2Type:")]
		void SetupWithAction1Title (string action1Title, string action2Title, MSFActionsCellActionType action1Type, MSFActionsCellActionType action2Type);

		// -(void)setupWithAction1Title:(NSString * _Nonnull)action1Title action1Type:(enum MSFActionsCellActionType)action1Type;
		[Export ("setupWithAction1Title:action1Type:")]
		void SetupWithAction1Title (string action1Title, MSFActionsCellActionType action1Type);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result("")));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);

		// -(void)didMoveToWindow;
		[Export ("didMoveToWindow")]
		void DidMoveToWindow ();

		// -(void)prepareForReuse __attribute__((objc_requires_super));
		[Export ("prepareForReuse")]
		[RequiresSuper]
		void PrepareForReuse ();

		// -(void)setHighlighted:(BOOL)highlighted animated:(BOOL)animated;
		[Export ("setHighlighted:animated:")]
		void SetHighlighted (bool highlighted, bool animated);

		// -(void)setSelected:(BOOL)selected animated:(BOOL)animated;
		[Export ("setSelected:animated:")]
		void SetSelected (bool selected, bool animated);
	}

	// @interface MSFActivityIndicatorCell : UITableViewCell
	[BaseType (typeof(UITableViewCell))]
	interface MSFActivityIndicatorCell
	{
		// @property (nonatomic) enum MSFTableViewCellBackgroundStyleType backgroundStyleType;
		[Export ("backgroundStyleType", ArgumentSemantic.Assign)]
		MSFTableViewCellBackgroundStyleType BackgroundStyleType { get; set; }

		// // -(instancetype _Nonnull)initWithStyle:(UITableViewCellStyle)style reuseIdentifier:(NSString * _Nullable)reuseIdentifier __attribute__((objc_designated_initializer));
		// [Export ("initWithStyle:reuseIdentifier:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (UITableViewCellStyle style, [NullAllowed] string reuseIdentifier);

		// -(instancetype _Nonnull)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)didMoveToWindow;
		[Export ("didMoveToWindow")]
		void DidMoveToWindow ();

		// -(void)prepareForReuse __attribute__((objc_requires_super));
		[Export ("prepareForReuse")]
		[RequiresSuper]
		void PrepareForReuse ();

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result("")));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);

		// -(void)setHighlighted:(BOOL)highlighted animated:(BOOL)animated;
		[Export ("setHighlighted:animated:")]
		void SetHighlighted (bool highlighted, bool animated);

		// -(void)setSelected:(BOOL)selected animated:(BOOL)animated;
		[Export ("setSelected:animated:")]
		void SetSelected (bool selected, bool animated);
	}

	// @protocol MSFAnimationSynchronizerProtocol
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
	interface IMSFAnimationSynchronizerProtocol
	{
		// @required @property (nonatomic, strong) CALayer * _Nullable referenceLayer;
		[Abstract]
		[NullAllowed, Export ("referenceLayer", ArgumentSemantic.Strong)]
		CALayer ReferenceLayer { get; set; }

		// @required -(CFTimeInterval)timeOffsetFor:(CALayer * _Nonnull)layer __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("timeOffsetFor:")]
		double TimeOffsetFor (CALayer layer);
	}

	// @interface MSFAnimationSynchronizer : NSObject <MSFAnimationSynchronizerProtocol>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MSFAnimationSynchronizer : IMSFAnimationSynchronizerProtocol
	{
		// -(instancetype _Nonnull)initWithReferenceLayer:(CALayer * _Nullable)referenceLayer __attribute__((objc_designated_initializer));
		[Export ("initWithReferenceLayer:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] CALayer referenceLayer);

		// @property (nonatomic, weak) CALayer * _Nullable referenceLayer;
		[NullAllowed, Export ("referenceLayer", ArgumentSemantic.Weak)]
		CALayer ReferenceLayer { get; set; }

		// -(CFTimeInterval)timeOffsetFor:(CALayer * _Nonnull)layer __attribute__((warn_unused_result("")));
		[Export ("timeOffsetFor:")]
		double TimeOffsetFor (CALayer layer);
	}

	// // @interface MSFBadgeField : UIView
	[BaseType (typeof(UIView))]
	interface MSFBadgeField
	{
		// @property (copy, nonatomic) NSString * _Nonnull label;
		[Export ("label")]
		string Label { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull placeholder;
		[Export ("placeholder")]
		string Placeholder { get; set; }

		// @property (nonatomic) NSInteger numberOfLines;
		[Export ("numberOfLines")]
		nint NumberOfLines { get; set; }

		// @property (nonatomic) BOOL isEditable;
		[Export ("isEditable")]
		bool IsEditable { get; set; }

		// @property (nonatomic) BOOL isActive;
		[Export ("isActive")]
		bool IsActive { get; set; }

		// @property (nonatomic) BOOL allowsDragAndDrop;
		[Export ("allowsDragAndDrop")]
		bool AllowsDragAndDrop { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull softBadgingCharacters;
		[Export ("softBadgingCharacters")]
		string SoftBadgingCharacters { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull hardBadgingCharacters;
		[Export ("hardBadgingCharacters")]
		string HardBadgingCharacters { get; set; }

		// @property (readonly, copy, nonatomic) NSArray<MSFBadgeView *> * _Nonnull badges;
		[Export ("badges", ArgumentSemantic.Copy)]
		MSFBadgeView[] Badges { get; }

		// @property (readonly, copy, nonatomic) NSArray<MSFBadgeViewDataSource *> * _Nonnull badgeDataSources;
		[Export ("badgeDataSources", ArgumentSemantic.Copy)]
		MSFBadgeViewDataSource[] BadgeDataSources { get; }

		[Wrap ("WeakBadgeFieldDelegate")]
		[NullAllowed]
		MSFBadgeFieldDelegate BadgeFieldDelegate { get; set; }

		// @property (nonatomic, weak) id<MSFBadgeFieldDelegate> _Nullable badgeFieldDelegate;
		[NullAllowed, Export ("badgeFieldDelegate", ArgumentSemantic.Weak)]
		NSObject WeakBadgeFieldDelegate { get; set; }

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// -(void)setupWithDataSources:(NSArray<MSFBadgeViewDataSource *> * _Nonnull)dataSources;
		[Export ("setupWithDataSources:")]
		void SetupWithDataSources (MSFBadgeViewDataSource[] dataSources);

		// -(void)reload;
		[Export ("reload")]
		void Reload ();

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result("")));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(CGFloat)heightThatFitsWithBadgeHeight:(CGFloat)badgeHeight numberOfLines:(NSInteger)numberOfLines __attribute__((warn_unused_result("")));
		[Export ("heightThatFitsWithBadgeHeight:numberOfLines:")]
		nfloat HeightThatFitsWithBadgeHeight (nfloat badgeHeight, nint numberOfLines);

		// -(void)badgeText;
		[Export ("badgeText")]
		void BadgeText ();

		// -(void)addBadgesWithDataSources:(NSArray<MSFBadgeViewDataSource *> * _Nonnull)dataSources;
		[Export ("addBadgesWithDataSources:")]
		void AddBadgesWithDataSources (MSFBadgeViewDataSource[] dataSources);

		// -(void)addBadgeWithDataSource:(MSFBadgeViewDataSource * _Nonnull)dataSource fromUserAction:(BOOL)fromUserAction updateConstrainedBadges:(BOOL)updateConstrainedBadges;
		[Export ("addBadgeWithDataSource:fromUserAction:updateConstrainedBadges:")]
		void AddBadgeWithDataSource (MSFBadgeViewDataSource dataSource, bool fromUserAction, bool updateConstrainedBadges);

		// -(void)deleteBadgesWithDataSource:(MSFBadgeViewDataSource * _Nonnull)dataSource;
		[Export ("deleteBadgesWithDataSource:")]
		void DeleteBadgesWithDataSource (MSFBadgeViewDataSource dataSource);

		// -(void)deleteAllBadges;
		[Export ("deleteAllBadges")]
		void DeleteAllBadges ();

		// -(void)selectBadge:(MSFBadgeView * _Nonnull)badge;
		[Export ("selectBadge:")]
		void SelectBadge (MSFBadgeView badge);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull textFieldContent;
		[Export ("textFieldContent")]
		string TextFieldContent { get; }

		// -(void)resetTextFieldContent;
		[Export ("resetTextFieldContent")]
		void ResetTextFieldContent ();

		// // -(BOOL)becomeFirstResponder;
		// [Export ("becomeFirstResponder")]
		// [Verify (MethodToProperty)]
		// bool BecomeFirstResponder { get; }

		// @property (readonly, nonatomic) BOOL isFirstResponder;
		[Export ("isFirstResponder")]
		bool IsFirstResponder { get; }

		// // -(BOOL)resignFirstResponder;
		// [Export ("resignFirstResponder")]
		// [Verify (MethodToProperty)]
		// bool ResignFirstResponder { get; }

		// -(NSInteger)accessibilityElementCount __attribute__((swift_attr("@UIActor"))) __attribute__((warn_unused_result("")));
		[Export ("accessibilityElementCount")]
		//[Verify (MethodToProperty)]
		nint AccessibilityElementCount { get; }

		// -(id _Nullable)accessibilityElementAtIndex:(NSInteger)index __attribute__((swift_attr("@UIActor"))) __attribute__((warn_unused_result("")));
		[Export ("accessibilityElementAtIndex:")]
		[return: NullAllowed]
		NSObject AccessibilityElementAtIndex (nint index);

		// -(NSInteger)indexOfAccessibilityElement:(id _Nonnull)element __attribute__((swift_attr("@UIActor"))) __attribute__((warn_unused_result("")));
		[Export ("indexOfAccessibilityElement:")]
		nint IndexOfAccessibilityElement (NSObject element);

		// -(void)voiceOverFocusOnTextFieldAndAnnounce:(NSString * _Nullable)announcement;
		[Export ("voiceOverFocusOnTextFieldAndAnnounce:")]
		void VoiceOverFocusOnTextFieldAndAnnounce ([NullAllowed] string announcement);
	}

	// @protocol MSFBadgeViewDelegate
	[Protocol, Model]
    [BaseType (typeof(NSObject))]
	interface MSFBadgeViewDelegate
	{
		// @required -(void)didSelectBadge:(MSFBadgeView * _Nonnull)badge;
		[Abstract]
		[Export ("didSelectBadge:")]
		void DidSelectBadge (MSFBadgeView badge);

		// @required -(void)didTapSelectedBadge:(MSFBadgeView * _Nonnull)badge;
		[Abstract]
		[Export ("didTapSelectedBadge:")]
		void DidTapSelectedBadge (MSFBadgeView badge);
	}

// 	// @interface FluentUI_Swift_459 (MSFBadgeField) <MSFBadgeViewDelegate>
// 	[Category]
// 	[BaseType (typeof(MSFBadgeField))]
// 	interface MSFBadgeField_FluentUI_Swift_459 : IMSFBadgeViewDelegate
// 	{
// 		// -(void)didSelectBadge:(MSFBadgeView * _Nonnull)badge;
// 		[Export ("didSelectBadge:")]
// 		void DidSelectBadge (MSFBadgeView badge);

// 		// -(void)didTapSelectedBadge:(MSFBadgeView * _Nonnull)badge;
// 		[Export ("didTapSelectedBadge:")]
// 		void DidTapSelectedBadge (MSFBadgeView badge);
// 	}

// 	// @interface FluentUI_Swift_466 (MSFBadgeField) <UITextFieldDelegate>
// 	[Category]
// 	[BaseType (typeof(MSFBadgeField))]
// 	interface MSFBadgeField_FluentUI_Swift_466 : IUITextFieldDelegate
// 	{
// 		// -(BOOL)textFieldShouldBeginEditing:(UITextField * _Nonnull)textField __attribute__((warn_unused_result("")));
// 		[Export ("textFieldShouldBeginEditing:")]
// 		bool TextFieldShouldBeginEditing (UITextField textField);

// 		// -(void)textFieldDidBeginEditing:(UITextField * _Nonnull)textField;
// 		[Export ("textFieldDidBeginEditing:")]
// 		void TextFieldDidBeginEditing (UITextField textField);

// 		// -(BOOL)textFieldShouldEndEditing:(UITextField * _Nonnull)textField __attribute__((warn_unused_result("")));
// 		[Export ("textFieldShouldEndEditing:")]
// 		bool TextFieldShouldEndEditing (UITextField textField);

// 		// -(void)textFieldDidEndEditing:(UITextField * _Nonnull)textField;
// 		[Export ("textFieldDidEndEditing:")]
// 		void TextFieldDidEndEditing (UITextField textField);

// 		// -(BOOL)textFieldShouldReturn:(UITextField * _Nonnull)textField __attribute__((warn_unused_result("")));
// 		[Export ("textFieldShouldReturn:")]
// 		bool TextFieldShouldReturn (UITextField textField);

// 		// -(BOOL)textField:(UITextField * _Nonnull)textField shouldChangeCharactersInRange:(NSRange)range replacementString:(NSString * _Nonnull)string __attribute__((warn_unused_result("")));
// 		[Export ("textField:shouldChangeCharactersInRange:replacementString:")]
// 		bool TextField (UITextField textField, NSRange range, string @string);
// 	}

// 	// @protocol MSFBadgeFieldDelegate
	[Protocol, Model]
    [BaseType (typeof(NSObject))]
	interface MSFBadgeFieldDelegate
	{
		// @optional -(MSFBadgeViewDataSource * _Nonnull)badgeField:(MSFBadgeField * _Nonnull)badgeField badgeDataSourceForText:(NSString * _Nonnull)text __attribute__((warn_unused_result("")));
		[Export ("badgeField:badgeDataSourceForText:")]
		MSFBadgeViewDataSource BadgeFieldBadgeDataSourceForText (MSFBadgeField badgeField, string text);

		// @optional -(void)badgeField:(MSFBadgeField * _Nonnull)badgeField willChangeTextFieldContentWithText:(NSString * _Nonnull)newText;
		[Export ("badgeField:willChangeTextFieldContentWithText:")]
		void BadgeFieldWillChangeTextFieldContentWithText (MSFBadgeField badgeField, string newText);

		// @optional -(void)badgeFieldDidChangeTextFieldContent:(MSFBadgeField * _Nonnull)badgeField isPaste:(BOOL)isPaste;
		[Export ("badgeFieldDidChangeTextFieldContent:isPaste:")]
		void BadgeFieldDidChangeTextFieldContent (MSFBadgeField badgeField, bool isPaste);

		// @optional -(BOOL)badgeField:(MSFBadgeField * _Nonnull)badgeField shouldBadgeText:(NSString * _Nonnull)text forSoftBadgingString:(NSString * _Nonnull)badgingString __attribute__((warn_unused_result("")));
		[Export ("badgeField:shouldBadgeText:forSoftBadgingString:")]
		bool BadgeField (MSFBadgeField badgeField, string text, string badgingString);

		// @optional -(void)badgeField:(MSFBadgeField * _Nonnull)badgeField didAddBadge:(MSFBadgeView * _Nonnull)badge;
		[Export ("badgeField:didAddBadge:")]
		void BadgeFieldDidAddBadge (MSFBadgeField badgeField, MSFBadgeView badge);

		// @optional -(void)badgeField:(MSFBadgeField * _Nonnull)badgeField didDeleteBadge:(MSFBadgeView * _Nonnull)badge;
		[Export ("badgeField:didDeleteBadge:")]
		void BadgeFieldDidDeleteBadge (MSFBadgeField badgeField, MSFBadgeView badge);

		// @optional -(BOOL)badgeField:(MSFBadgeField * _Nonnull)badgeField shouldAddBadgeForBadgeDataSource:(MSFBadgeViewDataSource * _Nonnull)badgeDataSource __attribute__((warn_unused_result("")));
		[Export ("badgeField:shouldAddBadgeForBadgeDataSource:")]
		bool BadgeFieldShouldAddBadgeForBadgeDataSource (MSFBadgeField badgeField, MSFBadgeViewDataSource badgeDataSource);

		// @optional -(MSFBadgeView * _Nonnull)badgeField:(MSFBadgeField * _Nonnull)badgeField newBadgeForBadgeDataSource:(MSFBadgeViewDataSource * _Nonnull)badgeDataSource __attribute__((warn_unused_result("")));
		[Export ("badgeField:newBadgeForBadgeDataSource:")]
		MSFBadgeView BadgeFieldSewBadgeForBadgeDataSource (MSFBadgeField badgeField, MSFBadgeViewDataSource badgeDataSource);

		// @optional -(MSFBadgeView * _Nonnull)badgeField:(MSFBadgeField * _Nonnull)badgeField newMoreBadgeForBadgeDataSources:(NSArray<MSFBadgeViewDataSource *> * _Nonnull)badgeDataSources __attribute__((warn_unused_result("")));
		[Export ("badgeField:newMoreBadgeForBadgeDataSources:")]
		MSFBadgeView BadgeFieldNewMoreBadgeForBadgeDataSources (MSFBadgeField badgeField, MSFBadgeViewDataSource[] badgeDataSources);

		// @optional -(void)badgeFieldContentHeightDidChange:(MSFBadgeField * _Nonnull)badgeField;
		[Export ("badgeFieldContentHeightDidChange:")]
		void BadgeFieldContentHeightDidChange (MSFBadgeField badgeField);

		// @optional -(void)badgeField:(MSFBadgeField * _Nonnull)badgeField didTapSelectedBadge:(MSFBadgeView * _Nonnull)badge;
		[Export ("badgeField:didTapSelectedBadge:")]
		void BadgeFieldDidTapSelectedBadge (MSFBadgeField badgeField, MSFBadgeView badge);

		// @optional -(BOOL)badgeField:(MSFBadgeField * _Nonnull)badgeField shouldDragBadge:(MSFBadgeView * _Nonnull)badge __attribute__((warn_unused_result("")));
		[Export ("badgeField:shouldDragBadge:")]
		bool BadgeFieldShouldDragBadge (MSFBadgeField badgeField, MSFBadgeView badge);

		// @optional -(void)badgeField:(MSFBadgeField * _Nonnull)originbadgeField didEndDraggingOriginBadge:(MSFBadgeView * _Nonnull)originBadge toBadgeField:(MSFBadgeField * _Nullable)destinationBadgeField withNewBadge:(MSFBadgeView * _Nullable)newBadge;
		[Export ("badgeField:didEndDraggingOriginBadge:toBadgeField:withNewBadge:")]
		void BadgeField (MSFBadgeField originbadgeField, MSFBadgeView originBadge, [NullAllowed] MSFBadgeField destinationBadgeField, [NullAllowed] MSFBadgeView newBadge);

		// @optional -(BOOL)badgeFieldShouldBeginEditing:(MSFBadgeField * _Nonnull)badgeField __attribute__((warn_unused_result("")));
		[Export ("badgeFieldShouldBeginEditing:")]
		bool BadgeFieldShouldBeginEditing (MSFBadgeField badgeField);

		// @optional -(void)badgeFieldDidBeginEditing:(MSFBadgeField * _Nonnull)badgeField;
		[Export ("badgeFieldDidBeginEditing:")]
		void BadgeFieldDidBeginEditing (MSFBadgeField badgeField);

		// @optional -(void)badgeFieldDidEndEditing:(MSFBadgeField * _Nonnull)badgeField;
		[Export ("badgeFieldDidEndEditing:")]
		void BadgeFieldDidEndEditing (MSFBadgeField badgeField);

		// @optional -(BOOL)badgeFieldShouldReturn:(MSFBadgeField * _Nonnull)badgeField __attribute__((warn_unused_result("")));
		[Export ("badgeFieldShouldReturn:")]
		bool BadgeFieldShouldReturn (MSFBadgeField badgeField);

		// @optional -(BOOL)badgeFieldShouldKeepBadgesActiveOnEndEditing:(MSFBadgeField * _Nonnull)badgeField __attribute__((warn_unused_result("")));
		[Export ("badgeFieldShouldKeepBadgesActiveOnEndEditing:")]
		bool BadgeFieldShouldKeepBadgesActiveOnEndEditing (MSFBadgeField badgeField);
	}

	// @interface MSFBadgeView : UIView
	[BaseType (typeof(UIView))]
	interface MSFBadgeView
	{
		[Wrap ("WeakDataSource")]
		[NullAllowed]
		MSFBadgeViewDataSource DataSource { get; set; }

		// @property (nonatomic, strong) MSFBadgeViewDataSource * _Nullable dataSource;
		[NullAllowed, Export ("dataSource", ArgumentSemantic.Strong)]
		NSObject WeakDataSource { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MSFBadgeViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MSFBadgeViewDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic) BOOL isActive;
		[Export ("isActive")]
		bool IsActive { get; set; }

		// @property (nonatomic) BOOL isSelected;
		[Export ("isSelected")]
		bool IsSelected { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable labelTextColor;
		[NullAllowed, Export ("labelTextColor", ArgumentSemantic.Strong)]
		UIColor LabelTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull selectedLabelTextColor;
		[Export ("selectedLabelTextColor", ArgumentSemantic.Strong)]
		UIColor SelectedLabelTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable disabledLabelTextColor;
		[NullAllowed, Export ("disabledLabelTextColor", ArgumentSemantic.Strong)]
		UIColor DisabledLabelTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
		[NullAllowed, Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable selectedBackgroundColor;
		[NullAllowed, Export ("selectedBackgroundColor", ArgumentSemantic.Strong)]
		UIColor SelectedBackgroundColor { get; set; }

		// @property (nonatomic) NSLineBreakMode lineBreakMode;
		[Export ("lineBreakMode", ArgumentSemantic.Assign)]
		NSLineBreakMode LineBreakMode { get; set; }

		// @property (nonatomic) CGFloat minWidth;
		[Export ("minWidth")]
		nfloat MinWidth { get; set; }

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(instancetype _Nonnull)initWithDataSource:(MSFBadgeViewDataSource * _Nonnull)dataSource __attribute__((objc_designated_initializer));
		[Export ("initWithDataSource:")]
		[DesignatedInitializer]
		NativeHandle Constructor (MSFBadgeViewDataSource dataSource);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result("")));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);

		// -(void)didMoveToWindow;
		[Export ("didMoveToWindow")]
		void DidMoveToWindow ();

		// @property (copy, nonatomic) NSString * _Nullable accessibilityLabel;
		[NullAllowed, Export ("accessibilityLabel")]
		string AccessibilityLabel { get; set; }
	}

	// @interface MSFBadgeViewDataSource : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MSFBadgeViewDataSource
	{
		// @property (copy, nonatomic) NSString * _Nonnull text;
		[Export ("text")]
		string Text { get; set; }

		// @property (nonatomic) enum MSFBadgeViewStyle style;
		[Export ("style", ArgumentSemantic.Assign)]
		MSFBadgeViewStyle Style { get; set; }

		// @property (nonatomic) enum MSFBadgeViewSize size;
		[Export ("size", ArgumentSemantic.Assign)]
		MSFBadgeViewSize Size { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable customView;
		[NullAllowed, Export ("customView", ArgumentSemantic.Strong)]
		UIView CustomView { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable customViewVerticalPadding;
		[NullAllowed, Export ("customViewVerticalPadding", ArgumentSemantic.Strong)]
		NSNumber CustomViewVerticalPadding { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable customViewPaddingLeft;
		[NullAllowed, Export ("customViewPaddingLeft", ArgumentSemantic.Strong)]
		NSNumber CustomViewPaddingLeft { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nullable customViewPaddingRight;
		[NullAllowed, Export ("customViewPaddingRight", ArgumentSemantic.Strong)]
		NSNumber CustomViewPaddingRight { get; set; }

		// -(instancetype _Nonnull)initWithText:(NSString * _Nonnull)text style:(enum MSFBadgeViewStyle)style size:(enum MSFBadgeViewSize)size __attribute__((objc_designated_initializer));
		[Export ("initWithText:style:size:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string text, MSFBadgeViewStyle style, MSFBadgeViewSize size);

		// -(instancetype _Nonnull)initWithText:(NSString * _Nonnull)text style:(enum MSFBadgeViewStyle)style size:(enum MSFBadgeViewSize)size customView:(UIView * _Nullable)customView customViewVerticalPadding:(NSNumber * _Nullable)customViewVerticalPadding customViewPaddingLeft:(NSNumber * _Nullable)customViewPaddingLeft customViewPaddingRight:(NSNumber * _Nullable)customViewPaddingRight;
		[Export ("initWithText:style:size:customView:customViewVerticalPadding:customViewPaddingLeft:customViewPaddingRight:")]
		NativeHandle Constructor (string text, MSFBadgeViewStyle style, MSFBadgeViewSize size, [NullAllowed] UIView customView, [NullAllowed] NSNumber customViewVerticalPadding, [NullAllowed] NSNumber customViewPaddingLeft, [NullAllowed] NSNumber customViewPaddingRight);
	}

// 	// @interface BarButtonItems : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC8FluentUI14BarButtonItems")]
	[DisableDefaultCtor]
	interface BarButtonItems
	{
	}

// 	// @interface MSFBlurringView : UIView
	[BaseType (typeof(UIView))]
	interface MSFBlurringView
	{
		// -(instancetype _Nonnull)initWithStyle:(UIBlurEffectStyle)style backgroundColor:(UIColor * _Nullable)backgroundColor __attribute__((objc_designated_initializer));
		[Export ("initWithStyle:backgroundColor:")]
		[DesignatedInitializer]
		NativeHandle Constructor (UIBlurEffectStyle style, [NullAllowed] UIColor backgroundColor);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)updateBackgroundWithBackgroundColor:(UIColor * _Nullable)backgroundColor;
		[Export ("updateBackgroundWithBackgroundColor:")]
		void UpdateBackgroundWithBackgroundColor ([NullAllowed] UIColor backgroundColor);
	}

// 	// @interface MSFTableViewCell : UITableViewCell
	[BaseType (typeof(UITableViewCell))]
	interface MSFTableViewCell
	{
		// @property (readonly, nonatomic, class) CGFloat smallHeight;
		[Static]
		[Export ("smallHeight")]
		nfloat SmallHeight { get; }

		// @property (readonly, nonatomic, class) CGFloat mediumHeight;
		[Static]
		[Export ("mediumHeight")]
		nfloat MediumHeight { get; }

		// @property (readonly, nonatomic, class) CGFloat largeHeight;
		[Static]
		[Export ("largeHeight")]
		nfloat LargeHeight { get; }

		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull identifier;
		[Static]
		[Export ("identifier")]
		string Identifier { get; }

		// @property (readonly, nonatomic, class) NSInteger defaultNumberOfLinesForLargerDynamicType;
		[Static]
		[Export ("defaultNumberOfLinesForLargerDynamicType")]
		nint DefaultNumberOfLinesForLargerDynamicType { get; }

		// @property (readonly, nonatomic, class) CGFloat defaultPaddingLeading;
		[Static]
		[Export ("defaultPaddingLeading")]
		nfloat DefaultPaddingLeading { get; }

		// @property (readonly, nonatomic, class) CGFloat defaultPaddingTrailing;
		[Static]
		[Export ("defaultPaddingTrailing")]
		nfloat DefaultPaddingTrailing { get; }

		// +(CGFloat)heightWithTitle:(NSString * _Nonnull)title subtitle:(NSString * _Nonnull)subtitle footer:(NSString * _Nonnull)footer titleLeadingAccessoryView:(UIView * _Nullable)titleLeadingAccessoryView titleTrailingAccessoryView:(UIView * _Nullable)titleTrailingAccessoryView subtitleLeadingAccessoryView:(UIView * _Nullable)subtitleLeadingAccessoryView subtitleTrailingAccessoryView:(UIView * _Nullable)subtitleTrailingAccessoryView footerLeadingAccessoryView:(UIView * _Nullable)footerLeadingAccessoryView footerTrailingAccessoryView:(UIView * _Nullable)footerTrailingAccessoryView customViewSize:(enum MSFTableViewCellCustomViewSize)customViewSize customAccessoryView:(UIView * _Nullable)customAccessoryView accessoryType:(enum MSFTableViewCellAccessoryType)accessoryType titleNumberOfLines:(NSInteger)titleNumberOfLines subtitleNumberOfLines:(NSInteger)subtitleNumberOfLines footerNumberOfLines:(NSInteger)footerNumberOfLines customAccessoryViewExtendsToEdge:(BOOL)customAccessoryViewExtendsToEdge containerWidth:(CGFloat)containerWidth isInSelectionMode:(BOOL)isInSelectionMode __attribute__((warn_unused_result("")));
		[Static]
		[Export ("heightWithTitle:subtitle:footer:titleLeadingAccessoryView:titleTrailingAccessoryView:subtitleLeadingAccessoryView:subtitleTrailingAccessoryView:footerLeadingAccessoryView:footerTrailingAccessoryView:customViewSize:customAccessoryView:accessoryType:titleNumberOfLines:subtitleNumberOfLines:footerNumberOfLines:customAccessoryViewExtendsToEdge:containerWidth:isInSelectionMode:")]
		nfloat HeightWithTitle (string title, string subtitle, string footer, [NullAllowed] UIView titleLeadingAccessoryView, [NullAllowed] UIView titleTrailingAccessoryView, [NullAllowed] UIView subtitleLeadingAccessoryView, [NullAllowed] UIView subtitleTrailingAccessoryView, [NullAllowed] UIView footerLeadingAccessoryView, [NullAllowed] UIView footerTrailingAccessoryView, MSFTableViewCellCustomViewSize customViewSize, [NullAllowed] UIView customAccessoryView, MSFTableViewCellAccessoryType accessoryType, nint titleNumberOfLines, nint subtitleNumberOfLines, nint footerNumberOfLines, bool customAccessoryViewExtendsToEdge, nfloat containerWidth, bool isInSelectionMode);

		// +(CGFloat)preferredWidthWithTitle:(NSString * _Nonnull)title subtitle:(NSString * _Nonnull)subtitle footer:(NSString * _Nonnull)footer titleLeadingAccessoryView:(UIView * _Nullable)titleLeadingAccessoryView titleTrailingAccessoryView:(UIView * _Nullable)titleTrailingAccessoryView subtitleLeadingAccessoryView:(UIView * _Nullable)subtitleLeadingAccessoryView subtitleTrailingAccessoryView:(UIView * _Nullable)subtitleTrailingAccessoryView footerLeadingAccessoryView:(UIView * _Nullable)footerLeadingAccessoryView footerTrailingAccessoryView:(UIView * _Nullable)footerTrailingAccessoryView customViewSize:(enum MSFTableViewCellCustomViewSize)customViewSize customAccessoryView:(UIView * _Nullable)customAccessoryView accessoryType:(enum MSFTableViewCellAccessoryType)accessoryType customAccessoryViewExtendsToEdge:(BOOL)customAccessoryViewExtendsToEdge isInSelectionMode:(BOOL)isInSelectionMode __attribute__((warn_unused_result("")));
		[Static]
		[Export ("preferredWidthWithTitle:subtitle:footer:titleLeadingAccessoryView:titleTrailingAccessoryView:subtitleLeadingAccessoryView:subtitleTrailingAccessoryView:footerLeadingAccessoryView:footerTrailingAccessoryView:customViewSize:customAccessoryView:accessoryType:customAccessoryViewExtendsToEdge:isInSelectionMode:")]
		nfloat PreferredWidthWithTitle (string title, string subtitle, string footer, [NullAllowed] UIView titleLeadingAccessoryView, [NullAllowed] UIView titleTrailingAccessoryView, [NullAllowed] UIView subtitleLeadingAccessoryView, [NullAllowed] UIView subtitleTrailingAccessoryView, [NullAllowed] UIView footerLeadingAccessoryView, [NullAllowed] UIView footerTrailingAccessoryView, MSFTableViewCellCustomViewSize customViewSize, [NullAllowed] UIView customAccessoryView, MSFTableViewCellAccessoryType accessoryType, bool customAccessoryViewExtendsToEdge, bool isInSelectionMode);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull subtitle;
		[Export ("subtitle")]
		string Subtitle { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull footer;
		[Export ("footer")]
		string Footer { get; }

		// @property (nonatomic, strong) NSAttributedString * _Nullable attributedTitle;
		[NullAllowed, Export ("attributedTitle", ArgumentSemantic.Strong)]
		NSAttributedString AttributedTitle { get; set; }

		// @property (nonatomic, strong) NSAttributedString * _Nullable attributedSubtitle;
		[NullAllowed, Export ("attributedSubtitle", ArgumentSemantic.Strong)]
		NSAttributedString AttributedSubtitle { get; set; }

		// @property (nonatomic, strong) NSAttributedString * _Nullable attributedFooter;
		[NullAllowed, Export ("attributedFooter", ArgumentSemantic.Strong)]
		NSAttributedString AttributedFooter { get; set; }

		// @property (nonatomic) CGFloat paddingLeading;
		[Export ("paddingLeading")]
		nfloat PaddingLeading { get; set; }

		// @property (nonatomic) CGFloat paddingTrailing;
		[Export ("paddingTrailing")]
		nfloat PaddingTrailing { get; set; }

		// @property (nonatomic) NSInteger titleNumberOfLines;
		[Export ("titleNumberOfLines")]
		nint TitleNumberOfLines { get; set; }

		// @property (nonatomic) NSInteger subtitleNumberOfLines;
		[Export ("subtitleNumberOfLines")]
		nint SubtitleNumberOfLines { get; set; }

		// @property (nonatomic) NSInteger footerNumberOfLines;
		[Export ("footerNumberOfLines")]
		nint FooterNumberOfLines { get; set; }

		// @property (nonatomic) NSInteger titleNumberOfLinesForLargerDynamicType;
		[Export ("titleNumberOfLinesForLargerDynamicType")]
		nint TitleNumberOfLinesForLargerDynamicType { get; set; }

		// @property (nonatomic) NSInteger subtitleNumberOfLinesForLargerDynamicType;
		[Export ("subtitleNumberOfLinesForLargerDynamicType")]
		nint SubtitleNumberOfLinesForLargerDynamicType { get; set; }

		// @property (nonatomic) NSInteger footerNumberOfLinesForLargerDynamicType;
		[Export ("footerNumberOfLinesForLargerDynamicType")]
		nint FooterNumberOfLinesForLargerDynamicType { get; set; }

		// @property (nonatomic) NSLineBreakMode titleLineBreakMode;
		[Export ("titleLineBreakMode", ArgumentSemantic.Assign)]
		NSLineBreakMode TitleLineBreakMode { get; set; }

		// @property (nonatomic) NSLineBreakMode subtitleLineBreakMode;
		[Export ("subtitleLineBreakMode", ArgumentSemantic.Assign)]
		NSLineBreakMode SubtitleLineBreakMode { get; set; }

		// @property (nonatomic) NSLineBreakMode footerLineBreakMode;
		[Export ("footerLineBreakMode", ArgumentSemantic.Assign)]
		NSLineBreakMode FooterLineBreakMode { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable titleLeadingAccessoryView;
		[NullAllowed, Export ("titleLeadingAccessoryView", ArgumentSemantic.Strong)]
		UIView TitleLeadingAccessoryView { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable titleTrailingAccessoryView;
		[NullAllowed, Export ("titleTrailingAccessoryView", ArgumentSemantic.Strong)]
		UIView TitleTrailingAccessoryView { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable subtitleLeadingAccessoryView;
		[NullAllowed, Export ("subtitleLeadingAccessoryView", ArgumentSemantic.Strong)]
		UIView SubtitleLeadingAccessoryView { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable subtitleTrailingAccessoryView;
		[NullAllowed, Export ("subtitleTrailingAccessoryView", ArgumentSemantic.Strong)]
		UIView SubtitleTrailingAccessoryView { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable footerLeadingAccessoryView;
		[NullAllowed, Export ("footerLeadingAccessoryView", ArgumentSemantic.Strong)]
		UIView FooterLeadingAccessoryView { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable footerTrailingAccessoryView;
		[NullAllowed, Export ("footerTrailingAccessoryView", ArgumentSemantic.Strong)]
		UIView FooterTrailingAccessoryView { get; set; }

		// @property (nonatomic) enum MSFTableViewCellCustomViewSize customViewSize;
		[Export ("customViewSize", ArgumentSemantic.Assign)]
		MSFTableViewCellCustomViewSize CustomViewSize { get; set; }

		// @property (readonly, nonatomic, strong) UIView * _Nullable customAccessoryView;
		[NullAllowed, Export ("customAccessoryView", ArgumentSemantic.Strong)]
		UIView CustomAccessoryView { get; }

		// @property (nonatomic) BOOL customAccessoryViewExtendsToEdge;
		[Export ("customAccessoryViewExtendsToEdge")]
		bool CustomAccessoryViewExtendsToEdge { get; set; }

		// @property (nonatomic) enum MSFTableViewCellSeparatorType topSeparatorType;
		[Export ("topSeparatorType", ArgumentSemantic.Assign)]
		MSFTableViewCellSeparatorType TopSeparatorType { get; set; }

		// @property (nonatomic) enum MSFTableViewCellSeparatorType bottomSeparatorType;
		[Export ("bottomSeparatorType", ArgumentSemantic.Assign)]
		MSFTableViewCellSeparatorType BottomSeparatorType { get; set; }

		// @property (nonatomic) enum MSFTableViewCellBackgroundStyleType backgroundStyleType;
		[Export ("backgroundStyleType", ArgumentSemantic.Assign)]
		MSFTableViewCellBackgroundStyleType BackgroundStyleType { get; set; }

		// @property (nonatomic) BOOL isEnabled;
		[Export ("isEnabled")]
		bool IsEnabled { get; set; }

		// @property (nonatomic) BOOL isInSelectionMode;
		[Export ("isInSelectionMode")]
		bool IsInSelectionMode { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(void) onAccessoryTapped;
		[NullAllowed, Export ("onAccessoryTapped", ArgumentSemantic.Copy)]
		Action OnAccessoryTapped { get; set; }

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// @property (nonatomic) CGRect bounds;
		[Export ("bounds", ArgumentSemantic.Assign)]
		CGRect Bounds { get; set; }

		// @property (nonatomic) CGRect frame;
		[Export ("frame", ArgumentSemantic.Assign)]
		CGRect Frame { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable accessibilityHint;
		[NullAllowed, Export ("accessibilityHint")]
		string AccessibilityHint { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable accessibilityValue;
		[NullAllowed, Export ("accessibilityValue")]
		string AccessibilityValue { get; set; }

		// @property (nonatomic) CGPoint accessibilityActivationPoint;
		[Export ("accessibilityActivationPoint", ArgumentSemantic.Assign)]
		CGPoint AccessibilityActivationPoint { get; set; }

		// -(instancetype _Nonnull)initWithStyle:(UITableViewCellStyle)style reuseIdentifier:(NSString * _Nullable)reuseIdentifier __attribute__((objc_designated_initializer));
		[Export ("initWithStyle:reuseIdentifier:")]
		[DesignatedInitializer]
		NativeHandle Constructor (UITableViewCellStyle style, [NullAllowed] string reuseIdentifier);

		// // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// -(void)setupWithTitle:(NSString * _Nonnull)title subtitle:(NSString * _Nonnull)subtitle footer:(NSString * _Nonnull)footer customView:(UIView * _Nullable)customView customAccessoryView:(UIView * _Nullable)customAccessoryView accessoryType:(enum MSFTableViewCellAccessoryType)accessoryType;
		[Export ("setupWithTitle:subtitle:footer:customView:customAccessoryView:accessoryType:")]
		void SetupWithTitle (string title, string subtitle, string footer, [NullAllowed] UIView customView, [NullAllowed] UIView customAccessoryView, MSFTableViewCellAccessoryType accessoryType);

		// -(void)setupWithTitle:(NSString * _Nonnull)title attributedTitle:(NSAttributedString * _Nullable)attributedTitle subtitle:(NSString * _Nonnull)subtitle attributedSubtitle:(NSAttributedString * _Nullable)attributedSubtitle footer:(NSString * _Nonnull)footer attributedFooter:(NSAttributedString * _Nullable)attributedFooter customView:(UIView * _Nullable)customView customAccessoryView:(UIView * _Nullable)customAccessoryView accessoryType:(enum MSFTableViewCellAccessoryType)accessoryType;
		[Export ("setupWithTitle:attributedTitle:subtitle:attributedSubtitle:footer:attributedFooter:customView:customAccessoryView:accessoryType:")]
		void SetupWithTitle (string title, [NullAllowed] NSAttributedString attributedTitle, string subtitle, [NullAllowed] NSAttributedString attributedSubtitle, string footer, [NullAllowed] NSAttributedString attributedFooter, [NullAllowed] UIView customView, [NullAllowed] UIView customAccessoryView, MSFTableViewCellAccessoryType accessoryType);

		// -(void)changeAccessoryTypeTo:(enum MSFTableViewCellAccessoryType)accessoryType;
		[Export ("changeAccessoryTypeTo:")]
		void ChangeAccessoryTypeTo (MSFTableViewCellAccessoryType accessoryType);

		// -(void)setIsInSelectionMode:(BOOL)isInSelectionMode animated:(BOOL)animated;
		[Export ("setIsInSelectionMode:animated:")]
		void SetIsInSelectionMode (bool isInSelectionMode, bool animated);

		// -(void)setTitleLabelTextColorWithColor:(UIColor * _Nonnull)color __attribute__((deprecated("Any color or stylistic changes on TableViewCell labels should be done through NSAttributedString (attributedTitle parameter of the setup method).")));
		[Export ("setTitleLabelTextColorWithColor:")]
		void SetTitleLabelTextColorWithColor (UIColor color);

		// -(void)setSubTitleLabelTextColorWithColor:(UIColor * _Nonnull)color __attribute__((deprecated("Any color or stylistic changes on TableViewCell labels should be done through NSAttributedString (attributedSubtitle parameter of the setup method).")));
		[Export ("setSubTitleLabelTextColorWithColor:")]
		void SetSubTitleLabelTextColorWithColor (UIColor color);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)prepareForReuse __attribute__((objc_requires_super));
		[Export ("prepareForReuse")]
		[RequiresSuper]
		void PrepareForReuse ();

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result("")));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);

		// -(void)touchesBegan:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesBegan:withEvent:")]
		void TouchesBegan (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)touchesCancelled:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesCancelled:withEvent:")]
		void TouchesCancelled (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)touchesEnded:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesEnded:withEvent:")]
		void TouchesEnded (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)didMoveToWindow;
		[Export ("didMoveToWindow")]
		void DidMoveToWindow ();

		// -(void)setSelected:(BOOL)selected animated:(BOOL)animated;
		[Export ("setSelected:animated:")]
		void SetSelected (bool selected, bool animated);

		// -(void)_bridgedUpdateConfigurationUsingState:(UICellConfigurationState * _Nonnull)state;
		[Export ("_bridgedUpdateConfigurationUsingState:")]
		void _bridgedUpdateConfigurationUsingState (UICellConfigurationState state);
	}

// 	// @interface MSFBooleanCell : MSFTableViewCell
	[BaseType (typeof(MSFTableViewCell))]
	interface MSFBooleanCell
	{
		// @property (nonatomic) BOOL isOn;
		[Export ("isOn")]
		bool IsOn { get; set; }

		// @property (nonatomic) BOOL isSwitchEnabled;
		[Export ("isSwitchEnabled")]
		bool IsSwitchEnabled { get; set; }

		// @property (nonatomic) BOOL isEnabled;
		[Export ("isEnabled")]
		bool IsEnabled { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(void) onValueChanged;
		[NullAllowed, Export ("onValueChanged", ArgumentSemantic.Copy)]
		Action OnValueChanged { get; set; }

		// -(instancetype _Nonnull)initWithStyle:(UITableViewCellStyle)style reuseIdentifier:(NSString * _Nullable)reuseIdentifier __attribute__((objc_designated_initializer));
		[Export ("initWithStyle:reuseIdentifier:")]
		[DesignatedInitializer]
		NativeHandle Constructor (UITableViewCellStyle style, [NullAllowed] string reuseIdentifier);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// -(void)setupWithTitle:(NSString * _Nonnull)title customView:(UIView * _Nullable)customView isOn:(BOOL)isOn;
		[Export ("setupWithTitle:customView:isOn:")]
		void SetupWithTitle (string title, [NullAllowed] UIView customView, bool isOn);

		// -(void)setupWithTitle:(NSString * _Nonnull)title customView:(UIView * _Nullable)customView isOn:(BOOL)isOn isSwitchEnabled:(BOOL)isSwitchEnabled;
		[Export ("setupWithTitle:customView:isOn:isSwitchEnabled:")]
		void SetupWithTitle (string title, [NullAllowed] UIView customView, bool isOn, bool isSwitchEnabled);

		// -(void)didMoveToWindow;
		[Export ("didMoveToWindow")]
		void DidMoveToWindow ();
	}

// 	// @interface MSFBottomCommandingController : UIViewController
	[BaseType (typeof(UIViewController))]
	interface MSFBottomCommandingController
	{
		// @property (nonatomic, strong) UIViewController * _Nullable contentViewController;
		[NullAllowed, Export ("contentViewController", ArgumentSemantic.Strong)]
		UIViewController ContentViewController { get; set; }

		// @property (copy, nonatomic) NSArray<MSFCommandingItem *> * _Nonnull heroItems;
		[Export ("heroItems", ArgumentSemantic.Copy)]
		MSFCommandingItem[] HeroItems { get; set; }

		// @property (copy, nonatomic) NSArray<MSFCommandingSection *> * _Nonnull expandedListSections;
		[Export ("expandedListSections", ArgumentSemantic.Copy)]
		MSFCommandingSection[] ExpandedListSections { get; set; }

		// @property (nonatomic) BOOL isHidden;
		[Export ("isHidden")]
		bool IsHidden { get; set; }

		// @property (nonatomic) BOOL prefersSheetMoreButtonVisible;
		[Export ("prefersSheetMoreButtonVisible")]
		bool PrefersSheetMoreButtonVisible { get; set; }

		// @property (nonatomic) BOOL sheetShouldAlwaysFillWidth;
		[Export ("sheetShouldAlwaysFillWidth")]
		bool SheetShouldAlwaysFillWidth { get; set; }

		// @property (readonly, nonatomic, strong) UILayoutGuide * _Nonnull commandingLayoutGuide;
		[Export ("commandingLayoutGuide", ArgumentSemantic.Strong)]
		UILayoutGuide CommandingLayoutGuide { get; }

		// @property (readonly, nonatomic) CGFloat collapsedHeightInSafeArea;
		[Export ("collapsedHeightInSafeArea")]
		nfloat CollapsedHeightInSafeArea { get; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MSFBottomCommandingControllerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MSFBottomCommandingControllerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(void)setIsHidden:(BOOL)isHidden animated:(BOOL)animated completion:(void (^ _Nullable)(BOOL))completion;
		[Export ("setIsHidden:animated:completion:")]
		void SetIsHidden (bool isHidden, bool animated, [NullAllowed] Action<bool> completion);

		// -(UIViewPropertyAnimator * _Nullable)prepareInteractiveIsHiddenChange:(BOOL)isHidden completion:(void (^ _Nullable)(UIViewAnimatingPosition))completion __attribute__((warn_unused_result("")));
		[Export ("prepareInteractiveIsHiddenChange:completion:")]
		[return: NullAllowed]
		UIViewPropertyAnimator PrepareInteractiveIsHiddenChange (bool isHidden, [NullAllowed] Action<UIViewAnimatingPosition> completion);

		// -(instancetype _Nonnull)initWith:(UIViewController * _Nullable)contentViewController __attribute__((objc_designated_initializer));
		[Export ("initWith:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] UIViewController contentViewController);

		// -(CGRect)rectForHeroItem:(MSFCommandingItem * _Nonnull)heroItem __attribute__((warn_unused_result("")));
		[Export ("rectForHeroItem:")]
		CGRect RectForHeroItem (MSFCommandingItem heroItem);

		// -(void)loadView;
		[Export ("loadView")]
		void LoadView ();

		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);

		// -(void)willTransitionToTraitCollection:(UITraitCollection * _Nonnull)newCollection withTransitionCoordinator:(id<UIViewControllerTransitionCoordinator> _Nonnull)coordinator;
		[Export ("willTransitionToTraitCollection:withTransitionCoordinator:")]
		void WillTransitionToTraitCollection (UITraitCollection newCollection, IUIViewControllerTransitionCoordinator coordinator);

		// -(void)viewSafeAreaInsetsDidChange __attribute__((objc_requires_super));
		[Export ("viewSafeAreaInsetsDidChange")]
		[RequiresSuper]
		void ViewSafeAreaInsetsDidChange ();

		// @property (copy, nonatomic) NSString * _Nullable handleExpandCustomAccessibilityLabel;
		[NullAllowed, Export ("handleExpandCustomAccessibilityLabel")]
		string HandleExpandCustomAccessibilityLabel { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable handleCollapseCustomAccessibilityLabel;
		[NullAllowed, Export ("handleCollapseCustomAccessibilityLabel")]
		string HandleCollapseCustomAccessibilityLabel { get; set; }
	}

// 	// @interface FluentUI_Swift_959 (MSFBottomCommandingController) <UIPopoverPresentationControllerDelegate>
// 	[Category]
// 	[BaseType (typeof(MSFBottomCommandingController))]
// 	interface MSFBottomCommandingController_FluentUI_Swift_959 : IUIPopoverPresentationControllerDelegate
// 	{
// 		// -(void)presentationControllerDidDismiss:(UIPresentationController * _Nonnull)presentationController;
// 		[Export ("presentationControllerDidDismiss:")]
// 		void PresentationControllerDidDismiss (UIPresentationController presentationController);
// 	}

// 	// @protocol MSFBottomSheetControllerDelegate
	[Protocol, Model]
    [BaseType (typeof(NSObject))]
	interface MSFBottomSheetControllerDelegate
	{
		// @optional -(void)bottomSheetController:(MSFBottomSheetController * _Nonnull)bottomSheetController didMoveTo:(enum BottomSheetExpansionState)expansionState interaction:(enum BottomSheetInteraction)interaction;
		[Export ("bottomSheetController:didMoveTo:interaction:")]
		void BottomSheetController (MSFBottomSheetController bottomSheetController, BottomSheetExpansionState expansionState, BottomSheetInteraction interaction);

		// @optional -(void)bottomSheetControllerCollapsedHeightInSafeAreaDidChange:(MSFBottomSheetController * _Nonnull)bottomSheetController;
		[Export ("bottomSheetControllerCollapsedHeightInSafeAreaDidChange:")]
		void BottomSheetControllerCollapsedHeightInSafeAreaDidChange (MSFBottomSheetController bottomSheetController);
	}

// 	// @interface FluentUI_Swift_984 (MSFBottomCommandingController) <MSFBottomSheetControllerDelegate>
// 	[Category]
// 	[BaseType (typeof(MSFBottomCommandingController))]
// 	interface MSFBottomCommandingController_FluentUI_Swift_984 : IMSFBottomSheetControllerDelegate
// 	{
// 		// -(void)bottomSheetControllerCollapsedHeightInSafeAreaDidChange:(MSFBottomSheetController * _Nonnull)bottomSheetController;
// 		[Export ("bottomSheetControllerCollapsedHeightInSafeAreaDidChange:")]
// 		void BottomSheetControllerCollapsedHeightInSafeAreaDidChange (MSFBottomSheetController bottomSheetController);

// 		// -(void)bottomSheetController:(MSFBottomSheetController * _Nonnull)bottomSheetController didMoveTo:(enum BottomSheetExpansionState)expansionState interaction:(enum BottomSheetInteraction)interaction;
// 		[Export ("bottomSheetController:didMoveTo:interaction:")]
// 		void BottomSheetController (MSFBottomSheetController bottomSheetController, BottomSheetExpansionState expansionState, BottomSheetInteraction interaction);
// 	}

// 	// @interface FluentUI_Swift_990 (MSFBottomCommandingController) <UITableViewDataSource>
// 	[Category]
// 	[BaseType (typeof(MSFBottomCommandingController))]
// 	interface MSFBottomCommandingController_FluentUI_Swift_990 : IUITableViewDataSource
// 	{
// 		// -(NSInteger)numberOfSectionsInTableView:(UITableView * _Nonnull)tableView __attribute__((warn_unused_result("")));
// 		[Export ("numberOfSectionsInTableView:")]
// 		nint NumberOfSectionsInTableView (UITableView tableView);

// 		// -(NSInteger)tableView:(UITableView * _Nonnull)tableView numberOfRowsInSection:(NSInteger)section __attribute__((warn_unused_result("")));
// 		[Export ("tableView:numberOfRowsInSection:")]
// 		nint TableView (UITableView tableView, nint section);

// 		// -(UITableViewCell * _Nonnull)tableView:(UITableView * _Nonnull)tableView cellForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result("")));
// 		[Export ("tableView:cellForRowAtIndexPath:")]
// 		UITableViewCell TableView (UITableView tableView, NSIndexPath indexPath);
// 	}

// 	// @interface FluentUI_Swift_997 (MSFBottomCommandingController) <UITableViewDelegate>
// 	[Category]
// 	[BaseType (typeof(MSFBottomCommandingController))]
// 	interface MSFBottomCommandingController_FluentUI_Swift_997 : IUITableViewDelegate
// 	{
// 		// -(CGFloat)tableView:(UITableView * _Nonnull)tableView heightForFooterInSection:(NSInteger)section __attribute__((warn_unused_result("")));
// 		[Export ("tableView:heightForFooterInSection:")]
// 		nfloat TableView (UITableView tableView, nint section);

// 		// -(UIView * _Nullable)tableView:(UITableView * _Nonnull)tableView viewForHeaderInSection:(NSInteger)section __attribute__((warn_unused_result("")));
// 		[Export ("tableView:viewForHeaderInSection:")]
// 		[return: NullAllowed]
// 		UIView TableView (UITableView tableView, nint section);

// 		// -(void)tableView:(UITableView * _Nonnull)tableView didSelectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
// 		[Export ("tableView:didSelectRowAtIndexPath:")]
// 		void TableView (UITableView tableView, NSIndexPath indexPath);
// 	}

// 	// @protocol MSFBottomCommandingControllerDelegate
	[Protocol, Model]
     [BaseType (typeof(NSObject))]
	interface MSFBottomCommandingControllerDelegate
	{
		// @optional -(void)bottomCommandingControllerCollapsedHeightInSafeAreaDidChange:(MSFBottomCommandingController * _Nonnull)bottomCommandingController;
		[Export ("bottomCommandingControllerCollapsedHeightInSafeAreaDidChange:")]
		void BottomCommandingControllerCollapsedHeightInSafeAreaDidChange (MSFBottomCommandingController bottomCommandingController);

		// @optional -(void)bottomCommandingController:(MSFBottomCommandingController * _Nonnull)bottomCommandingController sheetDidMoveTo:(enum BottomSheetExpansionState)expansionState commandingInteraction:(enum BottomCommandingInteraction)commandingInteraction sheetInteraction:(enum BottomSheetInteraction)sheetInteraction;
		[Export ("bottomCommandingController:sheetDidMoveTo:commandingInteraction:sheetInteraction:")]
		void BottomCommandingController (MSFBottomCommandingController bottomCommandingController, BottomSheetExpansionState expansionState, BottomCommandingInteraction commandingInteraction, BottomSheetInteraction sheetInteraction);

		// @optional -(void)bottomCommandingController:(MSFBottomCommandingController * _Nonnull)bottomCommandingController didPresentPopoverWith:(enum BottomCommandingInteraction)commandingInteraction;
		[Export ("bottomCommandingController:didPresentPopoverWith:")]
		void BottomCommandingControllerDidPresentPopoverWith (MSFBottomCommandingController bottomCommandingController, BottomCommandingInteraction commandingInteraction);

		// @optional -(void)bottomCommandingController:(MSFBottomCommandingController * _Nonnull)bottomCommandingController didDismissPopoverWith:(enum BottomCommandingInteraction)commandingInteraction;
		[Export ("bottomCommandingController:didDismissPopoverWith:")]
		void BottomCommandingControllerDidDismissPopoverWith (MSFBottomCommandingController bottomCommandingController, BottomCommandingInteraction commandingInteraction);
	}

// 	// @interface MSFBottomSheetController : UIViewController
	[BaseType (typeof(UIViewController))]
	interface MSFBottomSheetController
	{
		// -(instancetype _Nonnull)initWithHeaderContentView:(UIView * _Nullable)headerContentView expandedContentView:(UIView * _Nonnull)expandedContentView shouldShowDimmingView:(BOOL)shouldShowDimmingView __attribute__((objc_designated_initializer));
		[Export ("initWithHeaderContentView:expandedContentView:shouldShowDimmingView:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] UIView headerContentView, UIView expandedContentView, bool shouldShowDimmingView);

		// @property (readonly, nonatomic, strong) UIView * _Nullable headerContentView;
		[NullAllowed, Export ("headerContentView", ArgumentSemantic.Strong)]
		UIView HeaderContentView { get; }

		// @property (readonly, nonatomic, strong) UIView * _Nonnull expandedContentView;
		[Export ("expandedContentView", ArgumentSemantic.Strong)]
		UIView ExpandedContentView { get; }

		// @property (nonatomic, strong) UIScrollView * _Nullable hostedScrollView;
		[NullAllowed, Export ("hostedScrollView", ArgumentSemantic.Strong)]
		UIScrollView HostedScrollView { get; set; }

		// @property (nonatomic) BOOL isExpandable;
		[Export ("isExpandable")]
		bool IsExpandable { get; set; }

		// @property (nonatomic) BOOL isHidden;
		[Export ("isHidden")]
		bool IsHidden { get; set; }

		// @property (nonatomic) BOOL isFlexibleHeight;
		[Export ("isFlexibleHeight")]
		bool IsFlexibleHeight { get; set; }

		// @property (nonatomic) CGFloat headerContentHeight;
		[Export ("headerContentHeight")]
		nfloat HeaderContentHeight { get; set; }

		// @property (nonatomic) CGFloat preferredExpandedContentHeight;
		[Export ("preferredExpandedContentHeight")]
		nfloat PreferredExpandedContentHeight { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable handleExpandCustomAccessibilityLabel;
		[NullAllowed, Export ("handleExpandCustomAccessibilityLabel")]
		string HandleExpandCustomAccessibilityLabel { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable handleCollapseCustomAccessibilityLabel;
		[NullAllowed, Export ("handleCollapseCustomAccessibilityLabel")]
		string HandleCollapseCustomAccessibilityLabel { get; set; }

		// @property (nonatomic) BOOL isExpanded;
		[Export ("isExpanded")]
		bool IsExpanded { get; set; }

		// @property (copy, nonatomic) CGFloat (^ _Nullable)(MSFContentHeightResolutionContext * _Nonnull) collapsedHeightResolver;
		[NullAllowed, Export ("collapsedHeightResolver", ArgumentSemantic.Copy)]
		Func<MSFContentHeightResolutionContext, nfloat> CollapsedHeightResolver { get; set; }

		// @property (nonatomic) CGFloat collapsedContentHeight;
		[Export ("collapsedContentHeight")]
		nfloat CollapsedContentHeight { get; set; }

		// @property (nonatomic) BOOL shouldHideCollapsedContent;
		[Export ("shouldHideCollapsedContent")]
		bool ShouldHideCollapsedContent { get; set; }

		// @property (nonatomic) BOOL shouldAlwaysFillWidth;
		[Export ("shouldAlwaysFillWidth")]
		bool ShouldAlwaysFillWidth { get; set; }

		// @property (nonatomic) BOOL allowsSwipeToHide;
		[Export ("allowsSwipeToHide")]
		bool AllowsSwipeToHide { get; set; }

		// @property (readonly, nonatomic) CGFloat collapsedHeightInSafeArea;
		[Export ("collapsedHeightInSafeArea")]
		nfloat CollapsedHeightInSafeArea { get; }

		// @property (readonly, nonatomic, strong) UILayoutGuide * _Nonnull sheetLayoutGuide;
		[Export ("sheetLayoutGuide", ArgumentSemantic.Strong)]
		UILayoutGuide SheetLayoutGuide { get; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MSFBottomSheetControllerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MSFBottomSheetControllerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic, class) CGFloat resizingHandleHeight;
		[Static]
		[Export ("resizingHandleHeight")]
		nfloat ResizingHandleHeight { get; }

		// -(void)setIsExpanded:(BOOL)isExpanded animated:(BOOL)animated completion:(void (^ _Nullable)(BOOL))completion;
		[Export ("setIsExpanded:animated:completion:")]
		void SetIsExpanded (bool isExpanded, bool animated, [NullAllowed] Action<bool> completion);

		// -(void)setIsHidden:(BOOL)isHidden animated:(BOOL)animated completion:(void (^ _Nullable)(BOOL))completion;
		[Export ("setIsHidden:animated:completion:")]
		void SetIsHidden (bool isHidden, bool animated, [NullAllowed] Action<bool> completion);

		// -(UIViewPropertyAnimator * _Nullable)prepareInteractiveIsHiddenChange:(BOOL)isHidden completion:(void (^ _Nullable)(UIViewAnimatingPosition))completion __attribute__((warn_unused_result("")));
		[Export ("prepareInteractiveIsHiddenChange:completion:")]
		[return: NullAllowed]
		UIViewPropertyAnimator PrepareInteractiveIsHiddenChange (bool isHidden, [NullAllowed] Action<UIViewAnimatingPosition> completion);

		// -(void)invalidateSheetSize;
		[Export ("invalidateSheetSize")]
		void InvalidateSheetSize ();

		// -(void)loadView;
		[Export ("loadView")]
		void LoadView ();

		// -(void)viewDidLayoutSubviews;
		[Export ("viewDidLayoutSubviews")]
		void ViewDidLayoutSubviews ();

		// -(void)viewSafeAreaInsetsDidChange __attribute__((objc_requires_super));
		[Export ("viewSafeAreaInsetsDidChange")]
		[RequiresSuper]
		void ViewSafeAreaInsetsDidChange ();

		// -(void)willTransitionToTraitCollection:(UITraitCollection * _Nonnull)newCollection withTransitionCoordinator:(id<UIViewControllerTransitionCoordinator> _Nonnull)coordinator;
		[Export ("willTransitionToTraitCollection:withTransitionCoordinator:")]
		void WillTransitionToTraitCollection (UITraitCollection newCollection, IUIViewControllerTransitionCoordinator coordinator);
	}

// 	// @interface FluentUI_Swift_1153 (MSFBottomSheetController) <UIGestureRecognizerDelegate>
// 	[Category]
// 	[BaseType (typeof(MSFBottomSheetController))]
// 	interface MSFBottomSheetController_FluentUI_Swift_1153 : IUIGestureRecognizerDelegate
// 	{
// 		// -(BOOL)gestureRecognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer shouldBeRequiredToFailByGestureRecognizer:(UIGestureRecognizer * _Nonnull)otherGestureRecognizer __attribute__((warn_unused_result("")));
// 		[Export ("gestureRecognizer:shouldBeRequiredToFailByGestureRecognizer:")]
// 		bool GestureRecognizer (UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer);

// 		// -(BOOL)gestureRecognizerShouldBegin:(UIGestureRecognizer * _Nonnull)gestureRecognizer __attribute__((warn_unused_result("")));
// 		[Export ("gestureRecognizerShouldBegin:")]
// 		bool GestureRecognizerShouldBegin (UIGestureRecognizer gestureRecognizer);
// 	}

// 	// @interface MSFButton : UIButton
	[BaseType (typeof(UIButton))]
	interface MSFButton
	{
		// @property (nonatomic) enum MSFButtonStyle style;
		[Export ("style", ArgumentSemantic.Assign)]
		MSFButtonStyle Style { get; set; }

		// @property (nonatomic, strong) UIImage * _Nullable image;
		[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @property (getter = isHighlighted, nonatomic) BOOL highlighted;
		[Export ("highlighted")]
		bool Highlighted { [Bind ("isHighlighted")] get; set; }

		// @property (getter = isEnabled, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(void)didUpdateFocusInContext:(UIFocusUpdateContext * _Nonnull)context withAnimationCoordinator:(UIFocusAnimationCoordinator * _Nonnull)coordinator;
		[Export ("didUpdateFocusInContext:withAnimationCoordinator:")]
		void DidUpdateFocusInContext (UIFocusUpdateContext context, UIFocusAnimationCoordinator coordinator);

		// -(void)didMoveToWindow;
		[Export ("didMoveToWindow")]
		void DidMoveToWindow ();

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(CGRect)imageRectForContentRect:(CGRect)contentRect __attribute__((warn_unused_result("")));
		[Export ("imageRectForContentRect:")]
		CGRect ImageRectForContentRect (CGRect contentRect);

		// -(instancetype _Nonnull)initWithStyle:(enum MSFButtonStyle)style __attribute__((objc_designated_initializer));
		[Export ("initWithStyle:")]
		[DesignatedInitializer]
		NativeHandle Constructor (MSFButtonStyle style);

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect frame);

		// // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);
	}

// 	// @interface MSFCalendarConfiguration : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MSFCalendarConfiguration
	{
		// @property (readonly, getter = default, nonatomic, strong, class) MSFCalendarConfiguration * _Nonnull default_;
		[Static]
		[Export ("default_", ArgumentSemantic.Strong)]
		MSFCalendarConfiguration Default_ { [Bind ("default")] get; }

		// @property (nonatomic) NSInteger firstWeekday;
		[Export ("firstWeekday")]
		nint FirstWeekday { get; set; }

		// @property (copy, nonatomic) NSDate * _Nonnull referenceStartDate;
		[Export ("referenceStartDate", ArgumentSemantic.Copy)]
		NSDate ReferenceStartDate { get; set; }

		// @property (copy, nonatomic) NSDate * _Nonnull referenceEndDate;
		[Export ("referenceEndDate", ArgumentSemantic.Copy)]
		NSDate ReferenceEndDate { get; set; }

		// -(instancetype _Nonnull)initWithCalendar:(NSCalendar * _Nonnull)calendar __attribute__((objc_designated_initializer));
		[Export ("initWithCalendar:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSCalendar calendar);
	}

// 	// @protocol MSFCardDelegate
	[Protocol, Model]
    [BaseType (typeof(NSObject))]
	interface MSFCardDelegate
	{
		// @optional -(void)didTapCard:(MSFCardView * _Nonnull)card;
		[Export ("didTapCard:")]
		void DidTapCard (MSFCardView card);
	}

// 	// @interface MSFCardView : UIView
	[BaseType (typeof(UIView))]
	interface MSFCardView
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MSFCardDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MSFCardDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull primaryText;
		[Export ("primaryText")]
		string PrimaryText { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable secondaryText;
		[NullAllowed, Export ("secondaryText")]
		string SecondaryText { get; set; }

		// @property (nonatomic, strong) UIImage * _Nonnull icon;
		[Export ("icon", ArgumentSemantic.Strong)]
		UIImage Icon { get; set; }

		// @property (nonatomic) enum MSFCardColorStyle colorStyle;
		[Export ("colorStyle", ArgumentSemantic.Assign)]
		MSFCardColorStyle ColorStyle { get; set; }

		// @property (nonatomic) BOOL twoLineTitle;
		[Export ("twoLineTitle")]
		bool TwoLineTitle { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull customBackgroundColor;
		[Export ("customBackgroundColor", ArgumentSemantic.Strong)]
		UIColor CustomBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull customTitleColor;
		[Export ("customTitleColor", ArgumentSemantic.Strong)]
		UIColor CustomTitleColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull customSubtitleColor;
		[Export ("customSubtitleColor", ArgumentSemantic.Strong)]
		UIColor CustomSubtitleColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull customIconTintColor;
		[Export ("customIconTintColor", ArgumentSemantic.Strong)]
		UIColor CustomIconTintColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull customBorderColor;
		[Export ("customBorderColor", ArgumentSemantic.Strong)]
		UIColor CustomBorderColor { get; set; }

		// @property (nonatomic) CGFloat customWidth;
		[Export ("customWidth")]
		nfloat CustomWidth { get; set; }

		// -(instancetype _Nonnull)initWithSize:(enum MSFCardSize)size title:(NSString * _Nonnull)title subtitle:(NSString * _Nullable)subtitle icon:(UIImage * _Nonnull)icon colorStyle:(enum MSFCardColorStyle)colorStyle __attribute__((objc_designated_initializer));
		[Export ("initWithSize:title:subtitle:icon:colorStyle:")]
		[DesignatedInitializer]
		NativeHandle Constructor (MSFCardSize size, string title, [NullAllowed] string subtitle, UIImage icon, MSFCardColorStyle colorStyle);

		// -(void)didMoveToWindow;
		[Export ("didMoveToWindow")]
		void DidMoveToWindow ();

		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);
	}

// 	// @interface MSFCenteredLabelCell : UITableViewCell
	[BaseType (typeof(UITableViewCell))]
	interface MSFCenteredLabelCell
	{
		// @property (nonatomic) enum MSFTableViewCellBackgroundStyleType backgroundStyleType;
		[Export ("backgroundStyleType", ArgumentSemantic.Assign)]
		MSFTableViewCellBackgroundStyleType BackgroundStyleType { get; set; }

		// -(instancetype _Nonnull)initWithStyle:(UITableViewCellStyle)style reuseIdentifier:(NSString * _Nullable)reuseIdentifier __attribute__((objc_designated_initializer));
		[Export ("initWithStyle:reuseIdentifier:")]
		[DesignatedInitializer]
		NativeHandle Constructor (UITableViewCellStyle style, [NullAllowed] string reuseIdentifier);

		// -(instancetype _Nonnull)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// -(void)setupWithText:(NSString * _Nonnull)text;
		[Export ("setupWithText:")]
		void SetupWithText (string text);

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result("")));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)didMoveToWindow;
		[Export ("didMoveToWindow")]
		void DidMoveToWindow ();

		// -(void)setHighlighted:(BOOL)highlighted animated:(BOOL)animated;
		[Export ("setHighlighted:animated:")]
		void SetHighlighted (bool highlighted, bool animated);

		// -(void)setSelected:(BOOL)selected animated:(BOOL)animated;
		[Export ("setSelected:animated:")]
		void SetSelected (bool selected, bool animated);
	}

// 	// @protocol MSFColorProviding
// 	/*
//   Check whether adding [Model] to this declaration is appropriate.
//   [Model] is used to generate a C# class that implements this protocol,
//   and might be useful for protocols that consumers are supposed to implement,
//   since consumers can subclass the generated class instead of implementing
//   the generated interface. If consumers are not supposed to implement this
//   protocol, then [Model] is redundant and will generate code that will never
//   be used.
// */
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
	interface MSFColorProviding
	{
		// @required -(UIColor * _Nullable)primaryColorFor:(UIWindow * _Nonnull)window __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("primaryColorFor:")]
		[return: NullAllowed]
		UIColor PrimaryColorFor (UIWindow window);

		// @required -(UIColor * _Nullable)primaryTint10ColorFor:(UIWindow * _Nonnull)window __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("primaryTint10ColorFor:")]
		[return: NullAllowed]
		UIColor PrimaryTint10ColorFor (UIWindow window);

		// @required -(UIColor * _Nullable)primaryTint20ColorFor:(UIWindow * _Nonnull)window __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("primaryTint20ColorFor:")]
		[return: NullAllowed]
		UIColor PrimaryTint20ColorFor (UIWindow window);

		// @required -(UIColor * _Nullable)primaryTint30ColorFor:(UIWindow * _Nonnull)window __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("primaryTint30ColorFor:")]
		[return: NullAllowed]
		UIColor PrimaryTint30ColorFor (UIWindow window);

		// @required -(UIColor * _Nullable)primaryTint40ColorFor:(UIWindow * _Nonnull)window __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("primaryTint40ColorFor:")]
		[return: NullAllowed]
		UIColor PrimaryTint40ColorFor (UIWindow window);

		// @required -(UIColor * _Nullable)primaryShade10ColorFor:(UIWindow * _Nonnull)window __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("primaryShade10ColorFor:")]
		[return: NullAllowed]
		UIColor PrimaryShade10ColorFor (UIWindow window);

		// @required -(UIColor * _Nullable)primaryShade20ColorFor:(UIWindow * _Nonnull)window __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("primaryShade20ColorFor:")]
		[return: NullAllowed]
		UIColor PrimaryShade20ColorFor (UIWindow window);

		// @required -(UIColor * _Nullable)primaryShade30ColorFor:(UIWindow * _Nonnull)window __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("primaryShade30ColorFor:")]
		[return: NullAllowed]
		UIColor PrimaryShade30ColorFor (UIWindow window);
	}

// 	// @interface MSFColorValue : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MSFColorValue
	{
		// -(instancetype _Nonnull)init:(uint32_t)hexValue __attribute__((objc_designated_initializer));
		[Export ("init:")]
		[DesignatedInitializer]
		NativeHandle Constructor (uint hexValue);

		// -(instancetype _Nonnull)initWithR:(CGFloat)r g:(CGFloat)g b:(CGFloat)b a:(CGFloat)a __attribute__((objc_designated_initializer));
		[Export ("initWithR:g:b:a:")]
		[DesignatedInitializer]
		NativeHandle Constructor (nfloat r, nfloat g, nfloat b, nfloat a);
	}

// 	// @interface MSFColors : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MSFColors
	{
		// +(void)setProviderWithProvider:(id<MSFColorProviding> _Nonnull)provider for:(UIWindow * _Nonnull)window;
		[Static]
		[Export ("setProviderWithProvider:for:")]
		void SetProviderWithProvider (MSFColorProviding provider, UIWindow window);

		// +(void)removeProviderFor:(UIWindow * _Nonnull)window;
		[Static]
		[Export ("removeProviderFor:")]
		void RemoveProviderFor (UIWindow window);

		// +(UIColor * _Nonnull)primaryFor:(UIWindow * _Nonnull)window __attribute__((warn_unused_result("")));
		[Static]
		[Export ("primaryFor:")]
		UIColor PrimaryFor (UIWindow window);

		// +(UIColor * _Nonnull)primaryTint10For:(UIWindow * _Nonnull)window __attribute__((warn_unused_result("")));
		[Static]
		[Export ("primaryTint10For:")]
		UIColor PrimaryTint10For (UIWindow window);

		// +(UIColor * _Nonnull)primaryTint20For:(UIWindow * _Nonnull)window __attribute__((warn_unused_result("")));
		[Static]
		[Export ("primaryTint20For:")]
		UIColor PrimaryTint20For (UIWindow window);

		// +(UIColor * _Nonnull)primaryTint30For:(UIWindow * _Nonnull)window __attribute__((warn_unused_result("")));
		[Static]
		[Export ("primaryTint30For:")]
		UIColor PrimaryTint30For (UIWindow window);

		// +(UIColor * _Nonnull)primaryTint40For:(UIWindow * _Nonnull)window __attribute__((warn_unused_result("")));
		[Static]
		[Export ("primaryTint40For:")]
		UIColor PrimaryTint40For (UIWindow window);

		// +(UIColor * _Nonnull)primaryShade10For:(UIWindow * _Nonnull)window __attribute__((warn_unused_result("")));
		[Static]
		[Export ("primaryShade10For:")]
		UIColor PrimaryShade10For (UIWindow window);

		// +(UIColor * _Nonnull)primaryShade20For:(UIWindow * _Nonnull)window __attribute__((warn_unused_result("")));
		[Static]
		[Export ("primaryShade20For:")]
		UIColor PrimaryShade20For (UIWindow window);

		// +(UIColor * _Nonnull)primaryShade30For:(UIWindow * _Nonnull)window __attribute__((warn_unused_result("")));
		[Static]
		[Export ("primaryShade30For:")]
		UIColor PrimaryShade30For (UIWindow window);

		// @property (nonatomic, strong, class) UIColor * _Nonnull primary __attribute__((deprecated("", "setProvider(_:forWindow:)")));
		[Static]
		[Export ("primary", ArgumentSemantic.Strong)]
		UIColor Primary { get; set; }

		// @property (nonatomic, strong, class) UIColor * _Nonnull primaryTint10 __attribute__((deprecated("", "setProvider(_:forWindow:)")));
		[Static]
		[Export ("primaryTint10", ArgumentSemantic.Strong)]
		UIColor PrimaryTint10 { get; set; }

		// @property (nonatomic, strong, class) UIColor * _Nonnull primaryTint20 __attribute__((deprecated("", "setProvider(_:forWindow:)")));
		[Static]
		[Export ("primaryTint20", ArgumentSemantic.Strong)]
		UIColor PrimaryTint20 { get; set; }

		// @property (nonatomic, strong, class) UIColor * _Nonnull primaryTint30 __attribute__((deprecated("", "setProvider(_:forWindow:)")));
		[Static]
		[Export ("primaryTint30", ArgumentSemantic.Strong)]
		UIColor PrimaryTint30 { get; set; }

		// @property (nonatomic, strong, class) UIColor * _Nonnull primaryTint40 __attribute__((deprecated("", "setProvider(_:forWindow:)")));
		[Static]
		[Export ("primaryTint40", ArgumentSemantic.Strong)]
		UIColor PrimaryTint40 { get; set; }

		// @property (nonatomic, strong, class) UIColor * _Nonnull primaryShade10 __attribute__((deprecated("", "setProvider(_:forWindow:)")));
		[Static]
		[Export ("primaryShade10", ArgumentSemantic.Strong)]
		UIColor PrimaryShade10 { get; set; }

		// @property (nonatomic, strong, class) UIColor * _Nonnull primaryShade20 __attribute__((deprecated("", "setProvider(_:forWindow:)")));
		[Static]
		[Export ("primaryShade20", ArgumentSemantic.Strong)]
		UIColor PrimaryShade20 { get; set; }

		// @property (nonatomic, strong, class) UIColor * _Nonnull primaryShade30 __attribute__((deprecated("", "setProvider(_:forWindow:)")));
		[Static]
		[Export ("primaryShade30", ArgumentSemantic.Strong)]
		UIColor PrimaryShade30 { get; set; }

		// @property (nonatomic, strong, class) UIColor * _Nonnull foregroundOnPrimary __attribute__((deprecated("", "textOnAccent")));
		[Static]
		[Export ("foregroundOnPrimary", ArgumentSemantic.Strong)]
		UIColor ForegroundOnPrimary { get; set; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray950;
		[Static]
		[Export ("gray950", ArgumentSemantic.Strong)]
		UIColor Gray950 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray900;
		[Static]
		[Export ("gray900", ArgumentSemantic.Strong)]
		UIColor Gray900 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray800;
		[Static]
		[Export ("gray800", ArgumentSemantic.Strong)]
		UIColor Gray800 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray700;
		[Static]
		[Export ("gray700", ArgumentSemantic.Strong)]
		UIColor Gray700 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray600;
		[Static]
		[Export ("gray600", ArgumentSemantic.Strong)]
		UIColor Gray600 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray500;
		[Static]
		[Export ("gray500", ArgumentSemantic.Strong)]
		UIColor Gray500 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray400;
		[Static]
		[Export ("gray400", ArgumentSemantic.Strong)]
		UIColor Gray400 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray300;
		[Static]
		[Export ("gray300", ArgumentSemantic.Strong)]
		UIColor Gray300 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray200;
		[Static]
		[Export ("gray200", ArgumentSemantic.Strong)]
		UIColor Gray200 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray100;
		[Static]
		[Export ("gray100", ArgumentSemantic.Strong)]
		UIColor Gray100 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray50;
		[Static]
		[Export ("gray50", ArgumentSemantic.Strong)]
		UIColor Gray50 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray25;
		[Static]
		[Export ("gray25", ArgumentSemantic.Strong)]
		UIColor Gray25 { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull error;
		[Static]
		[Export ("error", ArgumentSemantic.Strong)]
		UIColor Error { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull warning;
		[Static]
		[Export ("warning", ArgumentSemantic.Strong)]
		UIColor Warning { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull communicationBlue;
		[Static]
		[Export ("communicationBlue", ArgumentSemantic.Strong)]
		UIColor CommunicationBlue { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull disabled __attribute__((deprecated("", "textDisabled")));
		[Static]
		[Export ("disabled", ArgumentSemantic.Strong)]
		UIColor Disabled { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull textDominant;
		[Static]
		[Export ("textDominant", ArgumentSemantic.Strong)]
		UIColor TextDominant { get; }

		// @property (nonatomic, strong, class) UIColor * _Nonnull textPrimary;
		[Static]
		[Export ("textPrimary", ArgumentSemantic.Strong)]
		UIColor TextPrimary { get; set; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull textSecondary;
		[Static]
		[Export ("textSecondary", ArgumentSemantic.Strong)]
		UIColor TextSecondary { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull textDisabled;
		[Static]
		[Export ("textDisabled", ArgumentSemantic.Strong)]
		UIColor TextDisabled { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull textOnAccent;
		[Static]
		[Export ("textOnAccent", ArgumentSemantic.Strong)]
		UIColor TextOnAccent { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull iconPrimary;
		[Static]
		[Export ("iconPrimary", ArgumentSemantic.Strong)]
		UIColor IconPrimary { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull iconSecondary;
		[Static]
		[Export ("iconSecondary", ArgumentSemantic.Strong)]
		UIColor IconSecondary { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull iconDisabled;
		[Static]
		[Export ("iconDisabled", ArgumentSemantic.Strong)]
		UIColor IconDisabled { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull iconOnAccent;
		[Static]
		[Export ("iconOnAccent", ArgumentSemantic.Strong)]
		UIColor IconOnAccent { get; }

		// @property (nonatomic, strong, class) UIColor * _Nonnull surfacePrimary;
		[Static]
		[Export ("surfacePrimary", ArgumentSemantic.Strong)]
		UIColor SurfacePrimary { get; set; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull surfaceSecondary;
		[Static]
		[Export ("surfaceSecondary", ArgumentSemantic.Strong)]
		UIColor SurfaceSecondary { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull surfaceTertiary;
		[Static]
		[Export ("surfaceTertiary", ArgumentSemantic.Strong)]
		UIColor SurfaceTertiary { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull surfaceQuaternary;
		[Static]
		[Export ("surfaceQuaternary", ArgumentSemantic.Strong)]
		UIColor SurfaceQuaternary { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull dividerOnPrimary;
		[Static]
		[Export ("dividerOnPrimary", ArgumentSemantic.Strong)]
		UIColor DividerOnPrimary { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull dividerOnSecondary;
		[Static]
		[Export ("dividerOnSecondary", ArgumentSemantic.Strong)]
		UIColor DividerOnSecondary { get; }

		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull dividerOnTertiary;
		[Static]
		[Export ("dividerOnTertiary", ArgumentSemantic.Strong)]
		UIColor DividerOnTertiary { get; }

		// +(UIColor * _Nonnull)colorFromPalette:(enum MSFColorPalette)palette __attribute__((warn_unused_result("")));
		[Static]
		[Export ("colorFromPalette:")]
		UIColor ColorFromPalette (MSFColorPalette palette);
	}

// 	// @interface FluentUI_Swift_1669 (MSFColors)
// 	[Category]
// 	[BaseType (typeof(MSFColors))]
// 	interface MSFColors_FluentUI_Swift_1669
// 	{
// 		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull drawerBackground;
// 		[Static]
// 		[Export ("drawerBackground", ArgumentSemantic.Strong)]
// 		UIColor DrawerBackground { get; }

// 		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull popoverBackground;
// 		[Static]
// 		[Export ("popoverBackground", ArgumentSemantic.Strong)]
// 		UIColor PopoverBackground { get; }
// 	}

// 	// @interface FluentUI_Swift_1677 (MSFColors)
// 	[Category]
// 	[BaseType (typeof(MSFColors))]
// 	interface MSFColors_FluentUI_Swift_1677
// 	{
// 		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull navigationBarBackground;
// 		[Static]
// 		[Export ("navigationBarBackground", ArgumentSemantic.Strong)]
// 		UIColor NavigationBarBackground { get; }
// 	}

// 	// @interface FluentUI_Swift_1683 (MSFColors)
// 	[Category]
// 	[BaseType (typeof(MSFColors))]
// 	interface MSFColors_FluentUI_Swift_1683
// 	{
// 		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull tableBackground;
// 		[Static]
// 		[Export ("tableBackground", ArgumentSemantic.Strong)]
// 		UIColor TableBackground { get; }

// 		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull tableBackgroundGrouped;
// 		[Static]
// 		[Export ("tableBackgroundGrouped", ArgumentSemantic.Strong)]
// 		UIColor TableBackgroundGrouped { get; }

// 		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull tableCellBackground;
// 		[Static]
// 		[Export ("tableCellBackground", ArgumentSemantic.Strong)]
// 		UIColor TableCellBackground { get; }

// 		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull tableCellBackgroundGrouped;
// 		[Static]
// 		[Export ("tableCellBackgroundGrouped", ArgumentSemantic.Strong)]
// 		UIColor TableCellBackgroundGrouped { get; }

// 		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull tableCellBackgroundSelected;
// 		[Static]
// 		[Export ("tableCellBackgroundSelected", ArgumentSemantic.Strong)]
// 		UIColor TableCellBackgroundSelected { get; }

// 		// @property (readonly, nonatomic, strong, class) UIColor * _Nonnull tableCellImage;
// 		[Static]
// 		[Export ("tableCellImage", ArgumentSemantic.Strong)]
// 		UIColor TableCellImage { get; }
// 	}

// 	// @interface MSFCommandBar : UIView
	[BaseType (typeof(UIView))]
	interface MSFCommandBar
	{
		// -(instancetype _Nonnull)initWithItemGroups:(NSArray<NSArray<MSFCommandBarItem *> *> * _Nonnull)itemGroups leadingItem:(MSFCommandBarItem * _Nullable)leadingItem trailingItem:(MSFCommandBarItem * _Nullable)trailingItem;
		[Export ("initWithItemGroups:leadingItem:trailingItem:")]
		NativeHandle Constructor (MSFCommandBarItem[] itemGroups, [NullAllowed] MSFCommandBarItem leadingItem, [NullAllowed] MSFCommandBarItem trailingItem);

		// -(instancetype _Nonnull)initWithItemGroups:(NSArray<NSArray<MSFCommandBarItem *> *> * _Nonnull)itemGroups leadingItemGroups:(NSArray<NSArray<MSFCommandBarItem *> *> * _Nullable)leadingItemGroups trailingItemGroups:(NSArray<NSArray<MSFCommandBarItem *> *> * _Nullable)trailingItemGroups __attribute__((objc_designated_initializer));
		[Export ("initWithItemGroups:leadingItemGroups:trailingItemGroups:")]
		[DesignatedInitializer]
		NativeHandle Constructor (MSFCommandBarItem[] itemGroups, [NullAllowed] MSFCommandBarItem[] leadingItemGroups, [NullAllowed] MSFCommandBarItem[] trailingItemGroups);

		// -(void)updateButtonsState;
		[Export ("updateButtonsState")]
		void UpdateButtonsState ();

		// -(void)resetScrollPosition:(BOOL)animated;
		[Export ("resetScrollPosition:")]
		void ResetScrollPosition (bool animated);

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();
	}

// 	// @interface FluentUI_Swift_1718 (MSFCommandBar) <UIScrollViewDelegate>
// 	[Category]
// 	[BaseType (typeof(MSFCommandBar))]
// 	interface MSFCommandBar_FluentUI_Swift_1718 : IUIScrollViewDelegate
// 	{
// 		// -(void)scrollViewDidScroll:(UIScrollView * _Nonnull)scrollView;
// 		[Export ("scrollViewDidScroll:")]
// 		void ScrollViewDidScroll (UIScrollView scrollView);
// 	}

// 	// @interface MSFCommandBarItem : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MSFCommandBarItem
	{
		// -(instancetype _Nonnull)initWithIconImage:(UIImage * _Nullable)iconImage title:(NSString * _Nullable)title titleFont:(UIFont * _Nullable)titleFont isEnabled:(BOOL)isEnabled isSelected:(BOOL)isSelected itemTappedHandler:(void (^ _Nonnull)(UIView * _Nonnull, MSFCommandBarItem * _Nonnull))itemTappedHandler accessibilityLabel:(NSString * _Nullable)accessibilityLabel accessibilityHint:(NSString * _Nullable)accessibilityHint __attribute__((objc_designated_initializer));
		[Export ("initWithIconImage:title:titleFont:isEnabled:isSelected:itemTappedHandler:accessibilityLabel:accessibilityHint:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] UIImage iconImage, [NullAllowed] string title, [NullAllowed] UIFont titleFont, bool isEnabled, bool isSelected, Action<UIView, MSFCommandBarItem> itemTappedHandler, [NullAllowed] string accessibilityLabel, [NullAllowed] string accessibilityHint);

		// -(instancetype _Nonnull)initWithIconImage:(UIImage * _Nullable)iconImage title:(NSString * _Nullable)title titleFont:(UIFont * _Nullable)titleFont isEnabled:(BOOL)isEnabled isSelected:(BOOL)isSelected itemTappedHandler:(void (^ _Nonnull)(UIView * _Nonnull, MSFCommandBarItem * _Nonnull))itemTappedHandler menu:(UIMenu * _Nonnull)menu showsMenuAsPrimaryAction:(BOOL)showsMenuAsPrimaryAction accessibilityLabel:(NSString * _Nullable)accessibilityLabel accessibilityHint:(NSString * _Nullable)accessibilityHint __attribute__((objc_designated_initializer));
		[Export ("initWithIconImage:title:titleFont:isEnabled:isSelected:itemTappedHandler:menu:showsMenuAsPrimaryAction:accessibilityLabel:accessibilityHint:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] UIImage iconImage, [NullAllowed] string title, [NullAllowed] UIFont titleFont, bool isEnabled, bool isSelected, Action<UIView, MSFCommandBarItem> itemTappedHandler, UIMenu menu, bool showsMenuAsPrimaryAction, [NullAllowed] string accessibilityLabel, [NullAllowed] string accessibilityHint);

		// @property (nonatomic, strong) UIImage * _Nullable iconImage;
		[NullAllowed, Export ("iconImage", ArgumentSemantic.Strong)]
		UIImage IconImage { get; set; }

		// @property (nonatomic, strong) UIImage * _Nullable accentImage;
		[NullAllowed, Export ("accentImage", ArgumentSemantic.Strong)]
		UIImage AccentImage { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable accentImageTintColor;
		[NullAllowed, Export ("accentImageTintColor", ArgumentSemantic.Strong)]
		UIColor AccentImageTintColor { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export ("title")]
		string Title { get; set; }

		// @property (nonatomic, strong) UIFont * _Nullable titleFont;
		[NullAllowed, Export ("titleFont", ArgumentSemantic.Strong)]
		UIFont TitleFont { get; set; }

		// @property (nonatomic) BOOL isEnabled;
		[Export ("isEnabled")]
		bool IsEnabled { get; set; }

		// @property (nonatomic) BOOL isHidden;
		[Export ("isHidden")]
		bool IsHidden { get; set; }

		// @property (nonatomic) BOOL isSelected;
		[Export ("isSelected")]
		bool IsSelected { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable accessibilityIdentifier;
		[NullAllowed, Export ("accessibilityIdentifier")]
		string AccessibilityIdentifier { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable accessibilityValue;
		[NullAllowed, Export ("accessibilityValue")]
		string AccessibilityValue { get; set; }

		// @property (copy, nonatomic) void (^ _Nonnull)(UIView * _Nonnull, MSFCommandBarItem * _Nonnull) itemTappedHandler;
		[Export ("itemTappedHandler", ArgumentSemantic.Copy)]
		Action<UIView, MSFCommandBarItem> ItemTappedHandler { get; set; }

		// @property (copy, nonatomic) UIView * _Nonnull (^ _Nullable)(void) customControlView;
		[NullAllowed, Export ("customControlView", ArgumentSemantic.Copy)]
		Func<UIView> CustomControlView { get; set; }

		// @property (nonatomic, strong) UIMenu * _Nullable menu;
		[NullAllowed, Export ("menu", ArgumentSemantic.Strong)]
		UIMenu Menu { get; set; }

		// @property (nonatomic) BOOL showsMenuAsPrimaryAction;
		[Export ("showsMenuAsPrimaryAction")]
		bool ShowsMenuAsPrimaryAction { get; set; }
	}

// 	// @interface MSFCommandingItem : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MSFCommandingItem
	{
		// @property (copy, nonatomic) void (^ _Nullable)(MSFCommandingItem * _Nonnull) action;
		[NullAllowed, Export ("action", ArgumentSemantic.Copy)]
		Action<MSFCommandingItem> Action { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export ("title")]
		string Title { get; set; }

		// @property (nonatomic, strong) UIImage * _Nullable image;
		[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @property (nonatomic, strong) UIImage * _Nullable selectedImage;
		[NullAllowed, Export ("selectedImage", ArgumentSemantic.Strong)]
		UIImage SelectedImage { get; set; }

		// @property (nonatomic, strong) UIImage * _Nullable largeImage;
		[NullAllowed, Export ("largeImage", ArgumentSemantic.Strong)]
		UIImage LargeImage { get; set; }

		// @property (nonatomic) BOOL isOn;
		[Export ("isOn")]
		bool IsOn { get; set; }

		// @property (nonatomic) BOOL isEnabled;
		[Export ("isEnabled")]
		bool IsEnabled { get; set; }

		// @property (nonatomic) NSInteger tag;
		[Export ("tag")]
		nint Tag { get; set; }

		// @property (readonly, nonatomic) BOOL isToggleable;
		[Export ("isToggleable")]
		bool IsToggleable { get; }

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title image:(UIImage * _Nonnull)image action:(void (^ _Nonnull)(MSFCommandingItem * _Nonnull))action isToggleable:(BOOL)isToggleable __attribute__((objc_designated_initializer));
		[Export ("initWithTitle:image:action:isToggleable:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string title, UIImage image, Action<MSFCommandingItem> action, bool isToggleable);

		// -(instancetype _Nonnull)initWithIsToggleable:(BOOL)isToggleable __attribute__((objc_designated_initializer));
		[Export ("initWithIsToggleable:")]
		[DesignatedInitializer]
		NativeHandle Constructor (bool isToggleable);
	}

// 	// @interface MSFCommandingSection : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MSFCommandingSection
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export ("title")]
		string Title { get; }

		// @property (copy, nonatomic) NSArray<MSFCommandingItem *> * _Nonnull items;
		[Export ("items", ArgumentSemantic.Copy)]
		MSFCommandingItem[] Items { get; set; }

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nullable)title items:(NSArray<MSFCommandingItem *> * _Nonnull)items __attribute__((objc_designated_initializer));
		[Export ("initWithTitle:items:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] string title, MSFCommandingItem[] items);
	}

// 	// @interface MSFContentHeightResolutionContext : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MSFContentHeightResolutionContext
	{
		// @property (readonly, nonatomic) CGFloat maximumHeight;
		[Export ("maximumHeight")]
		nfloat MaximumHeight { get; }

		// @property (readonly, nonatomic, strong) UITraitCollection * _Nonnull containerTraitCollection;
		[Export ("containerTraitCollection", ArgumentSemantic.Strong)]
		UITraitCollection ContainerTraitCollection { get; }
	}

// 	// @interface ControlHostingView : UIView
	[BaseType (typeof(UIView), Name = "_TtC8FluentUI18ControlHostingView")]
	interface ControlHostingView
	{
		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result("")));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder coder);
	}

// 	// @interface MSFDateTimePicker : NSObject
	[BaseType (typeof(NSObject))]
	interface MSFDateTimePicker
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MSFDateTimePickerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MSFDateTimePickerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(void)presentFrom:(UIViewController * _Nonnull)presentingController with:(enum MSFDateTimePickerMode)mode startDate:(NSDate * _Nonnull)startDate endDate:(NSDate * _Nullable)endDate datePickerType:(enum MSFDateTimePickerDatePickerType)datePickerType dateRangePresentation:(enum MSFDateTimePickerDateRangePresentation)dateRangePresentation titles:(MSFDateTimePickerTitles * _Nullable)titles;
		[Export ("presentFrom:with:startDate:endDate:datePickerType:dateRangePresentation:titles:")]
		void PresentFrom (UIViewController presentingController, MSFDateTimePickerMode mode, NSDate startDate, [NullAllowed] NSDate endDate, MSFDateTimePickerDatePickerType datePickerType, MSFDateTimePickerDateRangePresentation dateRangePresentation, [NullAllowed] MSFDateTimePickerTitles titles);

		// -(void)presentFrom:(UIViewController * _Nonnull)presentingController with:(enum MSFDateTimePickerMode)mode startDate:(NSDate * _Nonnull)startDate endDate:(NSDate * _Nullable)endDate calendarConfiguration:(MSFCalendarConfiguration * _Nullable)calendarConfiguration datePickerType:(enum MSFDateTimePickerDatePickerType)datePickerType dateRangePresentation:(enum MSFDateTimePickerDateRangePresentation)dateRangePresentation titles:(MSFDateTimePickerTitles * _Nullable)titles;
		[Export ("presentFrom:with:startDate:endDate:calendarConfiguration:datePickerType:dateRangePresentation:titles:")]
		void PresentFrom (UIViewController presentingController, MSFDateTimePickerMode mode, NSDate startDate, [NullAllowed] NSDate endDate, [NullAllowed] MSFCalendarConfiguration calendarConfiguration, MSFDateTimePickerDatePickerType datePickerType, MSFDateTimePickerDateRangePresentation dateRangePresentation, [NullAllowed] MSFDateTimePickerTitles titles);

		// -(void)presentFrom:(UIViewController * _Nonnull)presentingController with:(enum MSFDateTimePickerMode)mode startDate:(NSDate * _Nonnull)startDate endDate:(NSDate * _Nullable)endDate datePickerType:(enum MSFDateTimePickerDatePickerType)datePickerType dateRangePresentation:(enum MSFDateTimePickerDateRangePresentation)dateRangePresentation titles:(MSFDateTimePickerTitles * _Nullable)titles leftBarButtonItem:(UIBarButtonItem * _Nullable)leftBarButtonItem rightBarButtonItem:(UIBarButtonItem * _Nullable)rightBarButtonItem;
		[Export ("presentFrom:with:startDate:endDate:datePickerType:dateRangePresentation:titles:leftBarButtonItem:rightBarButtonItem:")]
		void PresentFrom (UIViewController presentingController, MSFDateTimePickerMode mode, NSDate startDate, [NullAllowed] NSDate endDate, MSFDateTimePickerDatePickerType datePickerType, MSFDateTimePickerDateRangePresentation dateRangePresentation, [NullAllowed] MSFDateTimePickerTitles titles, [NullAllowed] UIBarButtonItem leftBarButtonItem, [NullAllowed] UIBarButtonItem rightBarButtonItem);

		// -(void)presentFrom:(UIViewController * _Nonnull)presentingController with:(enum MSFDateTimePickerMode)mode startDate:(NSDate * _Nonnull)startDate endDate:(NSDate * _Nullable)endDate calendarConfiguration:(MSFCalendarConfiguration * _Nullable)calendarConfiguration datePickerType:(enum MSFDateTimePickerDatePickerType)datePickerType dateRangePresentation:(enum MSFDateTimePickerDateRangePresentation)dateRangePresentation titles:(MSFDateTimePickerTitles * _Nullable)titles leftBarButtonItem:(UIBarButtonItem * _Nullable)leftBarButtonItem rightBarButtonItem:(UIBarButtonItem * _Nullable)rightBarButtonItem;
		[Export ("presentFrom:with:startDate:endDate:calendarConfiguration:datePickerType:dateRangePresentation:titles:leftBarButtonItem:rightBarButtonItem:")]
		void PresentFrom (UIViewController presentingController, MSFDateTimePickerMode mode, NSDate startDate, [NullAllowed] NSDate endDate, [NullAllowed] MSFCalendarConfiguration calendarConfiguration, MSFDateTimePickerDatePickerType datePickerType, MSFDateTimePickerDateRangePresentation dateRangePresentation, [NullAllowed] MSFDateTimePickerTitles titles, [NullAllowed] UIBarButtonItem leftBarButtonItem, [NullAllowed] UIBarButtonItem rightBarButtonItem);

		// -(void)dismiss;
		[Export ("dismiss")]
		void Dismiss ();
	}

// 	// @interface MSFDateTimePickerTitles : NSObject
	[BaseType (typeof(NSObject))]
	interface MSFDateTimePickerTitles
	{
	}

// 	// @protocol MSFDateTimePickerDelegate
	[Protocol, Model]
    [BaseType (typeof(NSObject))]
	interface MSFDateTimePickerDelegate
	{
		// @required -(void)dateTimePicker:(MSFDateTimePicker * _Nonnull)dateTimePicker didPickStartDate:(NSDate * _Nonnull)startDate endDate:(NSDate * _Nonnull)endDate;
		[Abstract]
		[Export ("dateTimePicker:didPickStartDate:endDate:")]
		void DateTimePickerDidPickStartDate (MSFDateTimePicker dateTimePicker, NSDate startDate, NSDate endDate);

		// @optional -(BOOL)dateTimePicker:(MSFDateTimePicker * _Nonnull)dateTimePicker shouldEndPickingStartDate:(NSDate * _Nonnull)startDate endDate:(NSDate * _Nonnull)endDate __attribute__((warn_unused_result("")));
		[Export ("dateTimePicker:shouldEndPickingStartDate:endDate:")]
		bool DateTimePickerShouldEndPickingStartDate (MSFDateTimePicker dateTimePicker, NSDate startDate, NSDate endDate);
	}

// 	// @interface MSFDimmingView : UIView
	[BaseType (typeof(UIView))]
	interface MSFDimmingView
	{
		// -(instancetype _Nonnull)initWithType:(enum MSFDimmingViewType)type __attribute__((objc_designated_initializer));
		[Export ("initWithType:")]
		[DesignatedInitializer]
		NativeHandle Constructor (MSFDimmingViewType type);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);
	}

// 	// @interface MSFDotView : UIView
	[BaseType (typeof(UIView))]
	interface MSFDotView
	{
		// @property (nonatomic, strong) UIColor * _Nullable color;
		[NullAllowed, Export ("color", ArgumentSemantic.Strong)]
		UIColor Color { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// -(void)drawRect:(CGRect)rect;
		[Export ("drawRect:")]
		void DrawRect (CGRect rect);
	}

// 	// @interface MSFDrawerController : UIViewController
	[BaseType (typeof(UIViewController))]
	interface MSFDrawerController
	{
		// @property (nonatomic, strong) UIColor * _Nonnull backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic, strong) UIViewController * _Nullable contentController;
		[NullAllowed, Export ("contentController", ArgumentSemantic.Strong)]
		UIViewController ContentController { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable contentView;
		[NullAllowed, Export ("contentView", ArgumentSemantic.Strong)]
		UIView ContentView { get; set; }

		// @property (nonatomic, strong) UIScrollView * _Nullable contentScrollView;
		[NullAllowed, Export ("contentScrollView", ArgumentSemantic.Strong)]
		UIScrollView ContentScrollView { get; set; }

		// @property (nonatomic) enum MSFDrawerPresentationStyle presentationStyle;
		[Export ("presentationStyle", ArgumentSemantic.Assign)]
		MSFDrawerPresentationStyle PresentationStyle { get; set; }

		// @property (nonatomic) CGFloat presentationOffset;
		[Export ("presentationOffset")]
		nfloat PresentationOffset { get; set; }

		// @property (nonatomic) enum MSFDrawerPresentationBackground presentationBackground;
		[Export ("presentationBackground", ArgumentSemantic.Assign)]
		MSFDrawerPresentationBackground PresentationBackground { get; set; }

		// @property (nonatomic, weak) SWIFT_DEPRECATED_MSG("Use BottomSheetController for better accessibility support") UIView * passThroughView __attribute__((deprecated("Use BottomSheetController for better accessibility support")));
		[Export ("passThroughView", ArgumentSemantic.Weak)]
		UIView PassThroughView { get; set; }

		// @property (nonatomic, strong) UIPanGestureRecognizer * _Nullable presentingGesture;
		[NullAllowed, Export ("presentingGesture", ArgumentSemantic.Strong)]
		UIPanGestureRecognizer PresentingGesture { get; set; }

		// @property (nonatomic) enum MSFDrawerResizingBehavior resizingBehavior;
		[Export ("resizingBehavior", ArgumentSemantic.Assign)]
		MSFDrawerResizingBehavior ResizingBehavior { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull resizingHandleViewBackgroundColor;
		[Export ("resizingHandleViewBackgroundColor", ArgumentSemantic.Strong)]
		UIColor ResizingHandleViewBackgroundColor { get; set; }

		// @property (nonatomic) BOOL isExpanded;
		[Export ("isExpanded")]
		bool IsExpanded { get; set; }

		// @property (nonatomic) BOOL adjustsHeightForKeyboard;
		[Export ("adjustsHeightForKeyboard")]
		bool AdjustsHeightForKeyboard { get; set; }

		// @property (nonatomic) UIPopoverArrowDirection permittedArrowDirections;
		[Export ("permittedArrowDirections", ArgumentSemantic.Assign)]
		UIPopoverArrowDirection PermittedArrowDirections { get; set; }

		// @property (nonatomic) CGSize preferredContentSize;
		[Export ("preferredContentSize", ArgumentSemantic.Assign)]
		CGSize PreferredContentSize { get; set; }

		// @property (nonatomic) BOOL shouldUseWindowFullWidthInLandscape;
		[Export ("shouldUseWindowFullWidthInLandscape")]
		bool ShouldUseWindowFullWidthInLandscape { get; set; }

		// @property (nonatomic) BOOL shouldRespectSafeAreaForWindowFullWidth;
		[Export ("shouldRespectSafeAreaForWindowFullWidth")]
		bool ShouldRespectSafeAreaForWindowFullWidth { get; set; }

		// @property (readonly, nonatomic) BOOL shouldAutorotate;
		[Export ("shouldAutorotate")]
		bool ShouldAutorotate { get; }

		// @property (readonly, nonatomic) UIInterfaceOrientationMask supportedInterfaceOrientations;
		[Export ("supportedInterfaceOrientations")]
		UIInterfaceOrientationMask SupportedInterfaceOrientations { get; }

		// @property (copy, nonatomic) void (^ _Nullable)(void) onDismiss;
		[NullAllowed, Export ("onDismiss", ArgumentSemantic.Copy)]
		Action OnDismiss { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(void) onDismissCompleted;
		[NullAllowed, Export ("onDismissCompleted", ArgumentSemantic.Copy)]
		Action OnDismissCompleted { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MSFDrawerControllerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MSFDrawerControllerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype _Nonnull)initWithSourceView:(UIView * _Nonnull)sourceView sourceRect:(CGRect)sourceRect presentationOrigin:(CGFloat)presentationOrigin presentationDirection:(enum MSFDrawerPresentationDirection)presentationDirection preferredMaximumHeight:(CGFloat)preferredMaximumHeight __attribute__((objc_designated_initializer));
		[Export ("initWithSourceView:sourceRect:presentationOrigin:presentationDirection:preferredMaximumHeight:")]
		[DesignatedInitializer]
		NativeHandle Constructor (UIView sourceView, CGRect sourceRect, nfloat presentationOrigin, MSFDrawerPresentationDirection presentationDirection, nfloat preferredMaximumHeight);

		// -(instancetype _Nonnull)initWithBarButtonItem:(UIBarButtonItem * _Nonnull)barButtonItem presentationOrigin:(CGFloat)presentationOrigin presentationDirection:(enum MSFDrawerPresentationDirection)presentationDirection preferredMaximumHeight:(CGFloat)preferredMaximumHeight __attribute__((objc_designated_initializer));
		[Export ("initWithBarButtonItem:presentationOrigin:presentationDirection:preferredMaximumHeight:")]
		[DesignatedInitializer]
		NativeHandle Constructor (UIBarButtonItem barButtonItem, nfloat presentationOrigin, MSFDrawerPresentationDirection presentationDirection, nfloat preferredMaximumHeight);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// -(void)viewDidLoad;
		[Export ("viewDidLoad")]
		void ViewDidLoad ();

		// -(void)viewWillAppear:(BOOL)animated;
		[Export ("viewWillAppear:")]
		void ViewWillAppear (bool animated);

		// -(void)viewDidAppear:(BOOL)animated;
		[Export ("viewDidAppear:")]
		void ViewDidAppear (bool animated);

		// -(void)viewWillDisappear:(BOOL)animated;
		[Export ("viewWillDisappear:")]
		void ViewWillDisappear (bool animated);

		// -(void)viewDidDisappear:(BOOL)animated;
		[Export ("viewDidDisappear:")]
		void ViewDidDisappear (bool animated);

		// -(void)viewWillTransitionToSize:(CGSize)size withTransitionCoordinator:(id<UIViewControllerTransitionCoordinator> _Nonnull)coordinator;
		[Export ("viewWillTransitionToSize:withTransitionCoordinator:")]
		void ViewWillTransitionToSize (CGSize size, IUIViewControllerTransitionCoordinator coordinator);

		// -(void)willTransitionToTraitCollection:(UITraitCollection * _Nonnull)newCollection withTransitionCoordinator:(id<UIViewControllerTransitionCoordinator> _Nonnull)coordinator;
		[Export ("willTransitionToTraitCollection:withTransitionCoordinator:")]
		void WillTransitionToTraitCollection (UITraitCollection newCollection, IUIViewControllerTransitionCoordinator coordinator);

		// -(void)preferredContentSizeDidChangeForChildContentContainer:(id<UIContentContainer> _Nonnull)container;
		[Export ("preferredContentSizeDidChangeForChildContentContainer:")]
		void PreferredContentSizeDidChangeForChildContentContainer (UIContentContainer container);

		// -(BOOL)accessibilityPerformEscape __attribute__((warn_unused_result("")));
		[Export ("accessibilityPerformEscape")]
		// [Verify (MethodToProperty)]
		bool AccessibilityPerformEscape { get; }
	}

// 	// @interface FluentUI_Swift_2121 (MSFDrawerController) <UIGestureRecognizerDelegate>
// 	[Category]
// 	[BaseType (typeof(MSFDrawerController))]
// 	interface MSFDrawerController_FluentUI_Swift_2121 : IUIGestureRecognizerDelegate
// 	{
// 		// -(BOOL)gestureRecognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer shouldRecognizeSimultaneouslyWithGestureRecognizer:(UIGestureRecognizer * _Nonnull)otherGestureRecognizer __attribute__((warn_unused_result("")));
// 		[Export ("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:")]
// 		bool GestureRecognizer (UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer);
// 	}

// 	// @interface FluentUI_Swift_2127 (MSFDrawerController) <UIPopoverPresentationControllerDelegate>
// 	[Category]
// 	[BaseType (typeof(MSFDrawerController))]
// 	interface MSFDrawerController_FluentUI_Swift_2127 : IUIPopoverPresentationControllerDelegate
// 	{
// 		// -(UIModalPresentationStyle)adaptivePresentationStyleForPresentationController:(UIPresentationController * _Nonnull)controller traitCollection:(UITraitCollection * _Nonnull)traitCollection __attribute__((warn_unused_result("")));
// 		[Export ("adaptivePresentationStyleForPresentationController:traitCollection:")]
// 		UIModalPresentationStyle AdaptivePresentationStyleForPresentationController (UIPresentationController controller, UITraitCollection traitCollection);

// 		// -(BOOL)presentationControllerShouldDismiss:(UIPresentationController * _Nonnull)presentationController __attribute__((warn_unused_result("")));
// 		[Export ("presentationControllerShouldDismiss:")]
// 		bool PresentationControllerShouldDismiss (UIPresentationController presentationController);
// 	}

// 	// @interface FluentUI_Swift_2135 (MSFDrawerController) <UIViewControllerTransitioningDelegate>
// 	[Category]
// 	[BaseType (typeof(MSFDrawerController))]
// 	interface MSFDrawerController_FluentUI_Swift_2135 : IUIViewControllerTransitioningDelegate
// 	{
// 		// -(id<UIViewControllerAnimatedTransitioning> _Nullable)animationControllerForPresentedController:(UIViewController * _Nonnull)presented presentingController:(UIViewController * _Nonnull)presenting sourceController:(UIViewController * _Nonnull)source __attribute__((warn_unused_result("")));
// 		[Export ("animationControllerForPresentedController:presentingController:sourceController:")]
// 		[return: NullAllowed]
// 		UIViewControllerAnimatedTransitioning AnimationControllerForPresentedController (UIViewController presented, UIViewController presenting, UIViewController source);

// 		// -(id<UIViewControllerAnimatedTransitioning> _Nullable)animationControllerForDismissedController:(UIViewController * _Nonnull)dismissed __attribute__((warn_unused_result("")));
// 		[Export ("animationControllerForDismissedController:")]
// 		[return: NullAllowed]
// 		UIViewControllerAnimatedTransitioning AnimationControllerForDismissedController (UIViewController dismissed);

// 		// -(id<UIViewControllerInteractiveTransitioning> _Nullable)interactionControllerForPresentation:(id<UIViewControllerAnimatedTransitioning> _Nonnull)animator __attribute__((warn_unused_result("")));
// 		[Export ("interactionControllerForPresentation:")]
// 		[return: NullAllowed]
// 		UIViewControllerInteractiveTransitioning InteractionControllerForPresentation (UIViewControllerAnimatedTransitioning animator);

// 		// -(UIPresentationController * _Nullable)presentationControllerForPresentedViewController:(UIViewController * _Nonnull)presented presentingViewController:(UIViewController * _Nullable)presenting sourceViewController:(UIViewController * _Nonnull)source __attribute__((warn_unused_result("")));
// 		[Export ("presentationControllerForPresentedViewController:presentingViewController:sourceViewController:")]
// 		[return: NullAllowed]
// 		UIPresentationController PresentationControllerForPresentedViewController (UIViewController presented, [NullAllowed] UIViewController presenting, UIViewController source);
// 	}

// 	// @protocol MSFDrawerControllerDelegate
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
	interface MSFDrawerControllerDelegate
	{
		// @optional -(void)drawerControllerDidChangeExpandedState:(MSFDrawerController * _Nonnull)controller;
		[Export ("drawerControllerDidChangeExpandedState:")]
		void DrawerControllerDidChangeExpandedState (MSFDrawerController controller);

		// @optional -(void)drawerControllerWillDismiss:(MSFDrawerController * _Nonnull)controller;
		[Export ("drawerControllerWillDismiss:")]
		void DrawerControllerWillDismiss (MSFDrawerController controller);

		// @optional -(void)drawerControllerDidDismiss:(MSFDrawerController * _Nonnull)controller;
		[Export ("drawerControllerDidDismiss:")]
		void DrawerControllerDidDismiss (MSFDrawerController controller);

		// @optional -(BOOL)drawerControllerShouldDismissDrawer:(MSFDrawerController * _Nonnull)controller __attribute__((warn_unused_result("")));
		[Export ("drawerControllerShouldDismissDrawer:")]
		bool DrawerControllerShouldDismissDrawer (MSFDrawerController controller);
	}

// 	// @interface MSFEasyTapButton : UIButton
	[BaseType (typeof(UIButton))]
	interface MSFEasyTapButton
	{
		// -(BOOL)pointInside:(CGPoint)point withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result("")));
		[Export ("pointInside:withEvent:")]
		bool PointInside (CGPoint point, [NullAllowed] UIEvent @event);

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder coder);
	}

// 	// @interface MSFFileAccessoryViewAction : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MSFFileAccessoryViewAction
	{
		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title image:(UIImage * _Nonnull)image target:(id _Nullable)target action:(SEL _Nullable)action isEnabled:(BOOL)isEnabled canHide:(BOOL)canHide useAppPrimaryColor:(BOOL)useAppPrimaryColor __attribute__((objc_designated_initializer));
		[Export ("initWithTitle:image:target:action:isEnabled:canHide:useAppPrimaryColor:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string title, UIImage image, [NullAllowed] NSObject target, [NullAllowed] Selector action, bool isEnabled, bool canHide, bool useAppPrimaryColor);
	}

// 	// @interface FluentTheme : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC8FluentUI11FluentTheme")]
	interface FluentTheme
	{
	}

// 	// @interface FluentUIFramework : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC8FluentUI17FluentUIFramework")]
	interface FluentUIFramework
	{
		// @property (readonly, nonatomic, strong, class) NSBundle * _Nonnull resourceBundle;
		[Static]
		[Export ("resourceBundle", ArgumentSemantic.Strong)]
		NSBundle ResourceBundle { get; }

		// @property (readonly, nonatomic, strong, class) NSBundle * _Nonnull colorsBundle;
		[Static]
		[Export ("colorsBundle", ArgumentSemantic.Strong)]
		NSBundle ColorsBundle { get; }

		// @property (nonatomic, class) BOOL usesFluentIcons __attribute__((deprecated("Non-fluent icons no longer supported. Setting this var no longer has any effect and it will be removed in a future update.")));
		[Static]
		[Export ("usesFluentIcons")]
		bool UsesFluentIcons { get; set; }

		// +(void)initializeAppearance __attribute__((deprecated("", "initializeAppearanceWith:whenContainedInInstancesOf:")));
		[Static]
		[Export ("initializeAppearance")]
		void InitializeAppearance ();

		// +(void)initializeAppearanceWith:(UIColor * _Nonnull)primaryColor whenContainedInInstancesOf:(NSArray<Class<UIAppearanceContainer>> * _Nullable)containerTypes;
		[Static]
		[Export ("initializeAppearanceWith:whenContainedInInstancesOf:")]
		void InitializeAppearanceWith (UIColor primaryColor, [NullAllowed] UIAppearanceContainer[] containerTypes);
	}

// 	// @interface MSFFonts : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MSFFonts
	{
		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull largeTitle;
		[Static]
		[Export ("largeTitle", ArgumentSemantic.Strong)]
		UIFont LargeTitle { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull title1;
		[Static]
		[Export ("title1", ArgumentSemantic.Strong)]
		UIFont Title1 { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull title2;
		[Static]
		[Export ("title2", ArgumentSemantic.Strong)]
		UIFont Title2 { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull headline;
		[Static]
		[Export ("headline", ArgumentSemantic.Strong)]
		UIFont Headline { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull body;
		[Static]
		[Export ("body", ArgumentSemantic.Strong)]
		UIFont Body { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull subhead;
		[Static]
		[Export ("subhead", ArgumentSemantic.Strong)]
		UIFont Subhead { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull footnote;
		[Static]
		[Export ("footnote", ArgumentSemantic.Strong)]
		UIFont Footnote { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull button1;
		[Static]
		[Export ("button1", ArgumentSemantic.Strong)]
		UIFont Button1 { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull button2;
		[Static]
		[Export ("button2", ArgumentSemantic.Strong)]
		UIFont Button2 { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull caption1;
		[Static]
		[Export ("caption1", ArgumentSemantic.Strong)]
		UIFont Caption1 { get; }

		// @property (readonly, nonatomic, strong, class) UIFont * _Nonnull caption2;
		[Static]
		[Export ("caption2", ArgumentSemantic.Strong)]
		UIFont Caption2 { get; }
	}

// 	// @interface MSFGlobalTokens : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MSFGlobalTokens
	{
		// +(MSFColorValue * _Nonnull)neutralColorForToken:(enum MSFNeutralColorsToken)token __attribute__((warn_unused_result("")));
		[Static]
		[Export ("neutralColorForToken:")]
		MSFColorValue NeutralColorForToken (MSFNeutralColorsToken token);

		// +(MSFColorValue * _Nonnull)sharedColorForColorSet:(enum MSFSharedColorSets)sharedColor token:(enum MSFSharedColorsTokens)token __attribute__((warn_unused_result("")));
		[Static]
		[Export ("sharedColorForColorSet:token:")]
		MSFColorValue SharedColorForColorSet (MSFSharedColorSets sharedColor, MSFSharedColorsTokens token);
	}

// 	// @interface MSFHUD : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MSFHUD
	{
		// -(void)showIn:(UIView * _Nonnull)view;
		[Export ("showIn:")]
		void ShowIn (UIView view);

		// -(void)showIn:(UIView * _Nonnull)view with:(MSFHUDParams * _Nonnull)params;
		[Export ("showIn:with:")]
		void ShowIn (UIView view, MSFHUDParams @params);

		// -(void)showIn:(UIView * _Nonnull)view with:(MSFHUDParams * _Nonnull)params onTap:(void (^ _Nullable)(void))onTap;
		[Export ("showIn:with:onTap:")]
		void ShowIn (UIView view, MSFHUDParams @params, [NullAllowed] Action onTap);

		// -(void)showFrom:(UIViewController * _Nonnull)controller;
		[Export ("showFrom:")]
		void ShowFrom (UIViewController controller);

		// -(void)showFrom:(UIViewController * _Nonnull)controller with:(MSFHUDParams * _Nonnull)params;
		[Export ("showFrom:with:")]
		void ShowFrom (UIViewController controller, MSFHUDParams @params);

		// -(void)showFrom:(UIViewController * _Nonnull)controller with:(MSFHUDParams * _Nonnull)params onTap:(void (^ _Nullable)(void))onTap;
		[Export ("showFrom:with:onTap:")]
		void ShowFrom (UIViewController controller, MSFHUDParams @params, [NullAllowed] Action onTap);

		// -(void)showSuccessIn:(UIView * _Nonnull)view with:(NSString * _Nonnull)caption;
		[Export ("showSuccessIn:with:")]
		void ShowSuccessIn (UIView view, string caption);

		// -(void)showSuccessFrom:(UIViewController * _Nonnull)controller with:(NSString * _Nonnull)caption;
		[Export ("showSuccessFrom:with:")]
		void ShowSuccessFrom (UIViewController controller, string caption);

		// -(void)showFailureIn:(UIView * _Nonnull)view with:(NSString * _Nonnull)caption;
		[Export ("showFailureIn:with:")]
		void ShowFailureIn (UIView view, string caption);

		// -(void)showFailureFrom:(UIViewController * _Nonnull)controller with:(NSString * _Nonnull)caption;
		[Export ("showFailureFrom:with:")]
		void ShowFailureFrom (UIViewController controller, string caption);

		// -(void)hideAnimated:(BOOL)animated;
		[Export ("hideAnimated:")]
		void HideAnimated (bool animated);

		// -(void)updateWith:(NSString * _Nonnull)caption;
		[Export ("updateWith:")]
		void UpdateWith (string caption);

		// @property (readonly, nonatomic, strong, class) MSFHUD * _Nonnull shared;
		[Static]
		[Export ("shared", ArgumentSemantic.Strong)]
		MSFHUD Shared { get; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MSFHUDDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MSFHUDDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}

// 	// @protocol MSFHUDDelegate
	[Protocol, Model]
    [BaseType (typeof(NSObject))]
	interface MSFHUDDelegate
	{
		// @required -(UIWindow * _Nullable)defaultWindowForHUD:(MSFHUD * _Nonnull)hud __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("defaultWindowForHUD:")]
		[return: NullAllowed]
		UIWindow DefaultWindowForHUD (MSFHUD hud);
	}

// 	// @interface MSFHUDParams : NSObject
	[BaseType (typeof(NSObject))]
	interface MSFHUDParams
	{
		// @property (copy, nonatomic) NSString * _Nonnull caption;
		[Export ("caption")]
		string Caption { get; set; }

		// @property (nonatomic, strong) UIImage * _Nullable image;
		[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @property (nonatomic) BOOL isBlocking;
		[Export ("isBlocking")]
		bool IsBlocking { get; set; }

		// @property (nonatomic) BOOL isPersistent;
		[Export ("isPersistent")]
		bool IsPersistent { get; set; }

		// -(instancetype _Nonnull)initWithCaption:(NSString * _Nonnull)caption image:(UIImage * _Nullable)image isPersistent:(BOOL)isPersistent isBlocking:(BOOL)isBlocking;
		[Export ("initWithCaption:image:isPersistent:isBlocking:")]
		NativeHandle Constructor (string caption, [NullAllowed] UIImage image, bool isPersistent, bool isBlocking);
	}

// 	// @interface MSFLabel : UILabel
	[BaseType (typeof(UILabel))]
	interface MSFLabel
	{
		// @property (nonatomic) enum MSFTextColorStyle colorStyle;
		[Export ("colorStyle", ArgumentSemantic.Assign)]
		MSFTextColorStyle ColorStyle { get; set; }

		// @property (nonatomic) enum MSFTextStyle style;
		[Export ("style", ArgumentSemantic.Assign)]
		MSFTextStyle Style { get; set; }

		// @property (nonatomic) CGFloat maxFontSize;
		[Export ("maxFontSize")]
		nfloat MaxFontSize { get; set; }

		// @property (nonatomic, strong) UIColor * _Null_unspecified textColor;
		[Export ("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }

		// -(instancetype _Nonnull)initWithStyle:(enum MSFTextStyle)style colorStyle:(enum MSFTextColorStyle)colorStyle __attribute__((objc_designated_initializer));
		[Export ("initWithStyle:colorStyle:")]
		[DesignatedInitializer]
		NativeHandle Constructor (MSFTextStyle style, MSFTextColorStyle colorStyle);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// -(void)didMoveToWindow;
		[Export ("didMoveToWindow")]
		void DidMoveToWindow ();

		// @property (nonatomic, strong) NSAttributedString * _Nullable attributedText;
		[NullAllowed, Export ("attributedText", ArgumentSemantic.Strong)]
		NSAttributedString AttributedText { get; set; }
	}

// 	// @interface LinearGradientInfo : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC8FluentUI18LinearGradientInfo")]
	[DisableDefaultCtor]
	interface LinearGradientInfo
	{
	}

// 	// @interface MSFActivityIndicator : ControlHostingView
	[BaseType (typeof(ControlHostingView), Name = "_TtC8FluentUI20MSFActivityIndicator")]
	interface MSFActivityIndicator
	{
		// -(instancetype _Nonnull)initWithSize:(enum MSFActivityIndicatorSize)size __attribute__((objc_designated_initializer));
		[Export ("initWithSize:")]
		[DesignatedInitializer]
		NativeHandle Constructor (MSFActivityIndicatorSize size);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder coder);

		// @property (readonly, nonatomic, strong) id<MSFActivityIndicatorState> _Nonnull state;
		[Export ("state", ArgumentSemantic.Strong)]
		MSFActivityIndicatorState State { get; }
	}

// 	// @protocol MSFActivityIndicatorState
// 	/*
//   Check whether adding [Model] to this declaration is appropriate.
//   [Model] is used to generate a C# class that implements this protocol,
//   and might be useful for protocols that consumers are supposed to implement,
//   since consumers can subclass the generated class instead of implementing
//   the generated interface. If consumers are not supposed to implement this
//   protocol, then [Model] is redundant and will generate code that will never
//   be used.
// */
    [Protocol (Name = "_TtP8FluentUI25MSFActivityIndicatorState_")]
    [BaseType (typeof(NSObject))]
	interface MSFActivityIndicatorState
	{
		// @required @property (copy, nonatomic) NSString * _Nullable accessibilityLabel;
		[Abstract]
		[NullAllowed, Export ("accessibilityLabel")]
		string AccessibilityLabel { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nullable color;
		[Abstract]
		[NullAllowed, Export ("color", ArgumentSemantic.Strong)]
		UIColor Color { get; set; }

		// @required @property (nonatomic) BOOL isAnimating;
		[Abstract]
		[Export ("isAnimating")]
		bool IsAnimating { get; set; }

		// @required @property (nonatomic) BOOL hidesWhenStopped;
		[Abstract]
		[Export ("hidesWhenStopped")]
		bool HidesWhenStopped { get; set; }

		// @required @property (nonatomic) enum MSFActivityIndicatorSize size;
		[Abstract]
		[Export ("size", ArgumentSemantic.Assign)]
		MSFActivityIndicatorSize Size { get; set; }
	}

// 	// @interface MSFAvatar : ControlHostingView
	[BaseType (typeof(ControlHostingView), Name = "_TtC8FluentUI9MSFAvatar")]
	interface MSFAvatar
	{
		// -(instancetype _Nonnull)initWithStyle:(enum MSFAvatarStyle)style size:(enum MSFAvatarSize)size __attribute__((objc_designated_initializer));
		[Export ("initWithStyle:size:")]
		[DesignatedInitializer]
		NativeHandle Constructor (MSFAvatarStyle style, MSFAvatarSize size);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder coder);

		// @property (readonly, nonatomic, strong) id<MSFAvatarState> _Nonnull state;
		[Export ("state", ArgumentSemantic.Strong)]
		MSFAvatarState State { get; }
	}

// 	// @interface MSFAvatarGroup : ControlHostingView
	[BaseType (typeof(ControlHostingView), Name = "_TtC8FluentUI14MSFAvatarGroup")]
	interface MSFAvatarGroup
	{
		// -(instancetype _Nonnull)initWithStyle:(enum MSFAvatarGroupStyle)style size:(enum MSFAvatarSize)size __attribute__((objc_designated_initializer));
		[Export ("initWithStyle:size:")]
		[DesignatedInitializer]
		NativeHandle Constructor (MSFAvatarGroupStyle style, MSFAvatarSize size);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder coder);

		// @property (readonly, nonatomic, strong) id<MSFAvatarGroupState> _Nonnull state;
		[Export ("state", ArgumentSemantic.Strong)]
		MSFAvatarGroupState State { get; }
	}

// 	// @protocol MSFAvatarGroupAvatarState
// 	/*
//   Check whether adding [Model] to this declaration is appropriate.
//   [Model] is used to generate a C# class that implements this protocol,
//   and might be useful for protocols that consumers are supposed to implement,
//   since consumers can subclass the generated class instead of implementing
//   the generated interface. If consumers are not supposed to implement this
//   protocol, then [Model] is redundant and will generate code that will never
//   be used.
// */
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
	interface MSFAvatarGroupAvatarState
	{
		// @required @property (copy, nonatomic) NSString * _Nullable accessibilityLabel;
		[Abstract]
		[NullAllowed, Export ("accessibilityLabel")]
		string AccessibilityLabel { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
		[Abstract]
		[NullAllowed, Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nullable foregroundColor;
		[Abstract]
		[NullAllowed, Export ("foregroundColor", ArgumentSemantic.Strong)]
		UIColor ForegroundColor { get; set; }

		// @required @property (nonatomic) BOOL hasRingInnerGap;
		[Abstract]
		[Export ("hasRingInnerGap")]
		bool HasRingInnerGap { get; set; }

		// @required @property (nonatomic, strong) UIImage * _Nullable image;
		[Abstract]
		[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @required @property (nonatomic, strong) UIImage * _Nullable imageBasedRingColor;
		[Abstract]
		[NullAllowed, Export ("imageBasedRingColor", ArgumentSemantic.Strong)]
		UIImage ImageBasedRingColor { get; set; }

		// @required @property (nonatomic) BOOL isRingVisible;
		[Abstract]
		[Export ("isRingVisible")]
		bool IsRingVisible { get; set; }

		// @required @property (nonatomic) BOOL isTransparent;
		[Abstract]
		[Export ("isTransparent")]
		bool IsTransparent { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable primaryText;
		[Abstract]
		[NullAllowed, Export ("primaryText")]
		string PrimaryText { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nullable ringColor;
		[Abstract]
		[NullAllowed, Export ("ringColor", ArgumentSemantic.Strong)]
		UIColor RingColor { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable secondaryText;
		[Abstract]
		[NullAllowed, Export ("secondaryText")]
		string SecondaryText { get; set; }
	}

// 	// @protocol MSFAvatarGroupState
// 	/*
//   Check whether adding [Model] to this declaration is appropriate.
//   [Model] is used to generate a C# class that implements this protocol,
//   and might be useful for protocols that consumers are supposed to implement,
//   since consumers can subclass the generated class instead of implementing
//   the generated interface. If consumers are not supposed to implement this
//   protocol, then [Model] is redundant and will generate code that will never
//   be used.
// */
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
	interface MSFAvatarGroupState
	{
		// @required @property (nonatomic) NSInteger maxDisplayedAvatars;
		[Abstract]
		[Export ("maxDisplayedAvatars")]
		nint MaxDisplayedAvatars { get; set; }

		// @required @property (nonatomic) NSInteger overflowCount;
		[Abstract]
		[Export ("overflowCount")]
		nint OverflowCount { get; set; }

		// @required @property (nonatomic) enum MSFAvatarGroupStyle style;
		[Abstract]
		[Export ("style", ArgumentSemantic.Assign)]
		MSFAvatarGroupStyle Style { get; set; }

		// @required @property (nonatomic) enum MSFAvatarSize size;
		[Abstract]
		[Export ("size", ArgumentSemantic.Assign)]
		MSFAvatarSize Size { get; set; }

		// @required -(id<MSFAvatarGroupAvatarState> _Nonnull)createAvatar __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("createAvatar")]
		MSFAvatarGroupAvatarState CreateAvatar();

		// @required -(id<MSFAvatarGroupAvatarState> _Nonnull)createAvatarAt:(NSInteger)index __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("createAvatarAt:")]
		MSFAvatarGroupAvatarState CreateAvatarAt (nint index);

		// @required -(id<MSFAvatarGroupAvatarState> _Nonnull)getAvatarStateAt:(NSInteger)index __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("getAvatarStateAt:")]
		MSFAvatarGroupAvatarState GetAvatarStateAt (nint index);

		// @required -(void)removeAvatarAt:(NSInteger)index;
		[Abstract]
		[Export ("removeAvatarAt:")]
		void RemoveAvatarAt (nint index);
	}

// 	// @protocol MSFAvatarState
// 	/*
//   Check whether adding [Model] to this declaration is appropriate.
//   [Model] is used to generate a C# class that implements this protocol,
//   and might be useful for protocols that consumers are supposed to implement,
//   since consumers can subclass the generated class instead of implementing
//   the generated interface. If consumers are not supposed to implement this
//   protocol, then [Model] is redundant and will generate code that will never
//   be used.
// */
[Protocol, Model]
[BaseType (typeof(NSObject))]
	interface MSFAvatarState
	{
		// @required @property (copy, nonatomic) NSString * _Nullable accessibilityLabel;
		[Abstract]
		[NullAllowed, Export ("accessibilityLabel")]
		string AccessibilityLabel { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
		[Abstract]
		[NullAllowed, Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nullable foregroundColor;
		[Abstract]
		[NullAllowed, Export ("foregroundColor", ArgumentSemantic.Strong)]
		UIColor ForegroundColor { get; set; }

		// @required @property (nonatomic) BOOL hasButtonAccessibilityTrait;
		[Abstract]
		[Export ("hasButtonAccessibilityTrait")]
		bool HasButtonAccessibilityTrait { get; set; }

		// @required @property (nonatomic) BOOL hasPointerInteraction;
		[Abstract]
		[Export ("hasPointerInteraction")]
		bool HasPointerInteraction { get; set; }

		// @required @property (nonatomic) BOOL hasRingInnerGap;
		[Abstract]
		[Export ("hasRingInnerGap")]
		bool HasRingInnerGap { get; set; }

		// @required @property (nonatomic, strong) UIImage * _Nullable image;
		[Abstract]
		[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @required @property (nonatomic, strong) UIImage * _Nullable imageBasedRingColor;
		[Abstract]
		[NullAllowed, Export ("imageBasedRingColor", ArgumentSemantic.Strong)]
		UIImage ImageBasedRingColor { get; set; }

		// @required @property (nonatomic) BOOL isAnimated;
		[Abstract]
		[Export ("isAnimated")]
		bool IsAnimated { get; set; }

		// @required @property (nonatomic) BOOL isOutOfOffice;
		[Abstract]
		[Export ("isOutOfOffice")]
		bool IsOutOfOffice { get; set; }

		// @required @property (nonatomic) BOOL isRingVisible;
		[Abstract]
		[Export ("isRingVisible")]
		bool IsRingVisible { get; set; }

		// @required @property (nonatomic) BOOL isTransparent;
		[Abstract]
		[Export ("isTransparent")]
		bool IsTransparent { get; set; }

		// @required @property (nonatomic) enum MSFAvatarPresence presence;
		[Abstract]
		[Export ("presence", ArgumentSemantic.Assign)]
		MSFAvatarPresence Presence { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable primaryText;
		[Abstract]
		[NullAllowed, Export ("primaryText")]
		string PrimaryText { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nullable ringColor;
		[Abstract]
		[NullAllowed, Export ("ringColor", ArgumentSemantic.Strong)]
		UIColor RingColor { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable secondaryText;
		[Abstract]
		[NullAllowed, Export ("secondaryText")]
		string SecondaryText { get; set; }

		// @required @property (nonatomic) enum MSFAvatarSize size;
		[Abstract]
		[Export ("size", ArgumentSemantic.Assign)]
		MSFAvatarSize Size { get; set; }

		// @required @property (nonatomic) enum MSFAvatarStyle style;
		[Abstract]
		[Export ("style", ArgumentSemantic.Assign)]
		MSFAvatarStyle Style { get; set; }
	}

// 	// @interface MSFCardNudge : ControlHostingView
	[BaseType (typeof(ControlHostingView))]
	interface MSFCardNudge
	{
		// -(instancetype _Nonnull)initWithStyle:(enum MSFCardNudgeStyle)style title:(NSString * _Nonnull)title __attribute__((objc_designated_initializer));
		[Export ("initWithStyle:title:")]
		[DesignatedInitializer]
		NativeHandle Constructor (MSFCardNudgeStyle style, string title);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder coder);

		// @property (readonly, nonatomic, strong) id<MSFCardNudgeState> _Nonnull state;
		[Export ("state", ArgumentSemantic.Strong)]
		MSFCardNudgeState State { get; }
	}

// 	// @protocol MSFCardNudgeState <NSObject>
// 	/*
//   Check whether adding [Model] to this declaration is appropriate.
//   [Model] is used to generate a C# class that implements this protocol,
//   and might be useful for protocols that consumers are supposed to implement,
//   since consumers can subclass the generated class instead of implementing
//   the generated interface. If consumers are not supposed to implement this
//   protocol, then [Model] is redundant and will generate code that will never
//   be used.
// */
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MSFCardNudgeState
	{
		// @required @property (nonatomic) enum MSFCardNudgeStyle style;
		[Abstract]
		[Export ("style", ArgumentSemantic.Assign)]
		MSFCardNudgeStyle Style { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nonnull title;
		[Abstract]
		[Export ("title")]
		string Title { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable subtitle;
		[Abstract]
		[NullAllowed, Export ("subtitle")]
		string Subtitle { get; set; }

		// @required @property (nonatomic, strong) UIImage * _Nullable mainIcon;
		[Abstract]
		[NullAllowed, Export ("mainIcon", ArgumentSemantic.Strong)]
		UIImage MainIcon { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable accentText;
		[Abstract]
		[NullAllowed, Export ("accentText")]
		string AccentText { get; set; }

		// @required @property (nonatomic, strong) UIImage * _Nullable accentIcon;
		[Abstract]
		[NullAllowed, Export ("accentIcon", ArgumentSemantic.Strong)]
		UIImage AccentIcon { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable actionButtonTitle;
		[Abstract]
		[NullAllowed, Export ("actionButtonTitle")]
		string ActionButtonTitle { get; set; }

		// @required @property (copy, nonatomic) void (^ _Nullable)(id<MSFCardNudgeState> _Nonnull) actionButtonAction;
		[Abstract]
		[NullAllowed, Export ("actionButtonAction", ArgumentSemantic.Copy)]
		Action<MSFCardNudgeState> ActionButtonAction { get; set; }

		// @required @property (copy, nonatomic) void (^ _Nullable)(id<MSFCardNudgeState> _Nonnull) dismissButtonAction;
		[Abstract]
		[NullAllowed, Export ("dismissButtonAction", ArgumentSemantic.Copy)]
		Action<MSFCardNudgeState> DismissButtonAction { get; set; }
	}

// 	// @interface MSFDivider : ControlHostingView
	[BaseType (typeof(ControlHostingView), Name = "_TtC8FluentUI10MSFDivider")]
	interface MSFDivider
	{
		// -(instancetype _Nonnull)initWithOrientation:(enum MSFDividerOrientation)orientation spacing:(enum MSFDividerSpacing)spacing __attribute__((objc_designated_initializer));
		[Export ("initWithOrientation:spacing:")]
		[DesignatedInitializer]
		NativeHandle Constructor (MSFDividerOrientation orientation, MSFDividerSpacing spacing);

		// @property (readonly, nonatomic, strong) id<MSFDividerState> _Nonnull state;
		[Export ("state", ArgumentSemantic.Strong)]
		MSFDividerState State { get; }

		// @property (readonly, nonatomic, class) CGFloat thickness;
		[Static]
		[Export ("thickness")]
		nfloat Thickness { get; }
	}

// 	// @protocol MSFDividerState
// 	/*
//   Check whether adding [Model] to this declaration is appropriate.
//   [Model] is used to generate a C# class that implements this protocol,
//   and might be useful for protocols that consumers are supposed to implement,
//   since consumers can subclass the generated class instead of implementing
//   the generated interface. If consumers are not supposed to implement this
//   protocol, then [Model] is redundant and will generate code that will never
//   be used.
// */
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
	interface MSFDividerState
	{
		// @required @property (nonatomic) enum MSFDividerOrientation orientation;
		[Abstract]
		[Export ("orientation", ArgumentSemantic.Assign)]
		MSFDividerOrientation Orientation { get; set; }

		// @required @property (nonatomic) enum MSFDividerSpacing spacing;
		[Abstract]
		[Export ("spacing", ArgumentSemantic.Assign)]
		MSFDividerSpacing Spacing { get; set; }

		// @required @property (readonly, nonatomic) CGFloat thickness;
		[Abstract]
		[Export ("thickness")]
		nfloat Thickness { get; }
	}

// 	// @interface MSFHeadsUpDisplay : ControlHostingView
	[BaseType (typeof(ControlHostingView), Name = "_TtC8FluentUI17MSFHeadsUpDisplay")]
	interface MSFHeadsUpDisplay
	{
		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder coder);
	}

// 	// @interface MSFIndeterminateProgressBar : ControlHostingView
	[BaseType (typeof(ControlHostingView), Name = "_TtC8FluentUI27MSFIndeterminateProgressBar")]
	interface MSFIndeterminateProgressBar
	{
		// +(instancetype _Nonnull)new;
		[Static]
		[Export ("new")]
		MSFIndeterminateProgressBar New ();

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder coder);

		// @property (readonly, nonatomic, strong) id<MSFIndeterminateProgressBarState> _Nonnull state;
		[Export ("state", ArgumentSemantic.Strong)]
		MSFIndeterminateProgressBarState State { get; }
	}

// 	// @protocol MSFIndeterminateProgressBarState
// 	/*
//   Check whether adding [Model] to this declaration is appropriate.
//   [Model] is used to generate a C# class that implements this protocol,
//   and might be useful for protocols that consumers are supposed to implement,
//   since consumers can subclass the generated class instead of implementing
//   the generated interface. If consumers are not supposed to implement this
//   protocol, then [Model] is redundant and will generate code that will never
//   be used.
// */
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
	interface MSFIndeterminateProgressBarState
	{
		// @required @property (nonatomic) BOOL isAnimating;
		[Abstract]
		[Export ("isAnimating")]
		bool IsAnimating { get; set; }

		// @required @property (nonatomic) BOOL hidesWhenStopped;
		[Abstract]
		[Export ("hidesWhenStopped")]
		bool HidesWhenStopped { get; set; }
	}

// 	// @interface MSFNotification : ControlHostingView
	[BaseType (typeof(ControlHostingView), Name = "_TtC8FluentUI15MSFNotification")]
	interface MSFNotification
	{
		// -(instancetype _Nonnull)initWithStyle:(enum MSFNotificationStyle)style;
		[Export ("initWithStyle:")]
		NativeHandle Constructor (MSFNotificationStyle style);

		// -(instancetype _Nonnull)initWithStyle:(enum MSFNotificationStyle)style isFlexibleWidthToast:(BOOL)isFlexibleWidthToast __attribute__((objc_designated_initializer));
		[Export ("initWithStyle:isFlexibleWidthToast:")]
		[DesignatedInitializer]
		NativeHandle Constructor (MSFNotificationStyle style, bool isFlexibleWidthToast);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder coder);

		// @property (readonly, nonatomic, strong) id<MSFNotificationState> _Nonnull state;
		[Export ("state", ArgumentSemantic.Strong)]
		MSFNotificationState State { get; }

		// -(void)showIn:(UIView * _Nonnull)view from:(UIView * _Nullable)anchorView animated:(BOOL)animated completion:(void (^ _Nullable)(MSFNotification * _Nonnull))completion;
		[Export ("showIn:from:animated:completion:")]
		void ShowIn (UIView view, [NullAllowed] UIView anchorView, bool animated, [NullAllowed] Action<MSFNotification> completion);

		// -(void)hideAfter:(NSTimeInterval)delay animated:(BOOL)animated completion:(void (^ _Nullable)(void))completion;
		[Export ("hideAfter:animated:completion:")]
		void HideAfter (double delay, bool animated, [NullAllowed] Action completion);

		// @property (nonatomic, class) BOOL allowsMultipleToasts;
		[Static]
		[Export ("allowsMultipleToasts")]
		bool AllowsMultipleToasts { get; set; }
	}

// 	// @protocol MSFNotificationState <NSObject>
// 	/*
//   Check whether adding [Model] to this declaration is appropriate.
//   [Model] is used to generate a C# class that implements this protocol,
//   and might be useful for protocols that consumers are supposed to implement,
//   since consumers can subclass the generated class instead of implementing
//   the generated interface. If consumers are not supposed to implement this
//   protocol, then [Model] is redundant and will generate code that will never
//   be used.
// */
    [Protocol (Name = "_TtP8FluentUI20MSFNotificationState_")]
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

		// @required @property (nonatomic, strong) NSAttributedString * _Nullable attributedMessage;
		[Abstract]
		[NullAllowed, Export ("attributedMessage", ArgumentSemantic.Strong)]
		NSAttributedString AttributedMessage { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable title;
		[Abstract]
		[NullAllowed, Export ("title")]
		string Title { get; set; }

		// @required @property (nonatomic, strong) NSAttributedString * _Nullable attributedTitle;
		[Abstract]
		[NullAllowed, Export ("attributedTitle", ArgumentSemantic.Strong)]
		NSAttributedString AttributedTitle { get; set; }

		// @required @property (nonatomic, strong) UIImage * _Nullable image;
		[Abstract]
		[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @required @property (nonatomic, strong) UIImage * _Nullable trailingImage;
		[Abstract]
		[NullAllowed, Export ("trailingImage", ArgumentSemantic.Strong)]
		UIImage TrailingImage { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable trailingImageAccessibilityLabel;
		[Abstract]
		[NullAllowed, Export ("trailingImageAccessibilityLabel")]
		string TrailingImageAccessibilityLabel { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable actionButtonTitle;
		[Abstract]
		[NullAllowed, Export ("actionButtonTitle")]
		string ActionButtonTitle { get; set; }

		// @required @property (copy, nonatomic) void (^ _Nullable)(void) actionButtonAction;
		[Abstract]
		[NullAllowed, Export ("actionButtonAction", ArgumentSemantic.Copy)]
		Action ActionButtonAction { get; set; }

		// @required @property (nonatomic) BOOL showDefaultDismissActionButton;
		[Abstract]
		[Export ("showDefaultDismissActionButton")]
		bool ShowDefaultDismissActionButton { get; set; }

		// @required @property (copy, nonatomic) void (^ _Nullable)(void) messageButtonAction;
		[Abstract]
		[NullAllowed, Export ("messageButtonAction", ArgumentSemantic.Copy)]
		Action MessageButtonAction { get; set; }

		// @required @property (nonatomic) BOOL showFromBottom;
		[Abstract]
		[Export ("showFromBottom")]
		bool ShowFromBottom { get; set; }

		// @required @property (nonatomic, strong) LinearGradientInfo * _Nullable backgroundGradient;
		[Abstract]
		[NullAllowed, Export ("backgroundGradient", ArgumentSemantic.Strong)]
		LinearGradientInfo BackgroundGradient { get; set; }
	}

// 	// @interface MSFPersonaButton : ControlHostingView
	[BaseType (typeof(ControlHostingView), Name = "_TtC8FluentUI16MSFPersonaButton")]
	interface MSFPersonaButton
	{
		// -(instancetype _Nonnull)initWithSize:(enum MSFPersonaButtonSize)size __attribute__((objc_designated_initializer));
		[Export ("initWithSize:")]
		[DesignatedInitializer]
		NativeHandle Constructor (MSFPersonaButtonSize size);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder coder);

		// @property (readonly, nonatomic, strong) id<MSFPersonaButtonState> _Nonnull state;
		[Export ("state", ArgumentSemantic.Strong)]
		MSFPersonaButtonState State { get; }
	}

// 	// @interface MSFPersonaButtonCarousel : ControlHostingView
	[BaseType (typeof(ControlHostingView), Name = "_TtC8FluentUI24MSFPersonaButtonCarousel")]
	interface MSFPersonaButtonCarousel
	{
		// -(instancetype _Nonnull)initWithSize:(enum MSFPersonaButtonSize)size __attribute__((objc_designated_initializer));
		[Export ("initWithSize:")]
		[DesignatedInitializer]
		NativeHandle Constructor (MSFPersonaButtonSize size);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder coder);

		// @property (readonly, nonatomic, strong) id<MSFPersonaButtonCarouselState> _Nonnull state;
		[Export ("state", ArgumentSemantic.Strong)]
		MSFPersonaButtonCarouselState State { get; }
	}

// 	// @protocol MSFPersonaButtonCarouselState
// 	/*
//   Check whether adding [Model] to this declaration is appropriate.
//   [Model] is used to generate a C# class that implements this protocol,
//   and might be useful for protocols that consumers are supposed to implement,
//   since consumers can subclass the generated class instead of implementing
//   the generated interface. If consumers are not supposed to implement this
//   protocol, then [Model] is redundant and will generate code that will never
//   be used.
// */
    [Protocol (Name = "_TtP8FluentUI29MSFPersonaButtonCarouselState_")]
     [BaseType (typeof(NSObject))]
	interface MSFPersonaButtonCarouselState
	{
		// @required @property (readonly, nonatomic) enum MSFPersonaButtonSize buttonSize;
		[Abstract]
		[Export ("buttonSize")]
		MSFPersonaButtonSize ButtonSize { get; }

		// @required @property (copy, nonatomic) void (^ _Nullable)(id<MSFPersonaCarouselButtonState> _Nonnull, NSInteger) onTapAction;
		[Abstract]
		[NullAllowed, Export ("onTapAction", ArgumentSemantic.Copy)]
		Action<MSFPersonaCarouselButtonState, nint> OnTapAction { get; set; }

		// @required @property (readonly, nonatomic) NSInteger count;
		[Abstract]
		[Export ("count")]
		nint Count { get; }

		// @required -(id<MSFPersonaCarouselButtonState> _Nonnull)addWithPrimaryText:(NSString * _Nullable)primaryText secondaryText:(NSString * _Nullable)secondaryText image:(UIImage * _Nullable)image;
		[Abstract]
		[Export ("addWithPrimaryText:secondaryText:image:")]
		MSFPersonaCarouselButtonState AddWithPrimaryText ([NullAllowed] string primaryText, [NullAllowed] string secondaryText, [NullAllowed] UIImage image);

		// @required -(id<MSFPersonaCarouselButtonState> _Nullable)personaButtonStateAt:(NSInteger)index __attribute__((warn_unused_result("")));
		[Abstract]
		[Export ("personaButtonStateAt:")]
		[return: NullAllowed]
		MSFPersonaCarouselButtonState PersonaButtonStateAt (nint index);

		// @required -(void)remove:(id<MSFPersonaCarouselButtonState> _Nonnull)personaState;
		[Abstract]
		[Export ("remove:")]
		void Remove (MSFPersonaCarouselButtonState personaState);

		// @required -(void)removeAt:(NSInteger)index;
		[Abstract]
		[Export ("removeAt:")]
		void RemoveAt (nint index);
	}

// 	// @protocol MSFPersonaButtonState
// 	/*
//   Check whether adding [Model] to this declaration is appropriate.
//   [Model] is used to generate a C# class that implements this protocol,
//   and might be useful for protocols that consumers are supposed to implement,
//   since consumers can subclass the generated class instead of implementing
//   the generated interface. If consumers are not supposed to implement this
//   protocol, then [Model] is redundant and will generate code that will never
//   be used.
// */
    [Protocol (Name = "_TtP8FluentUI21MSFPersonaButtonState_")]
     [BaseType (typeof(NSObject))]
	interface MSFPersonaButtonState
	{
		// @required @property (nonatomic) enum MSFPersonaButtonSize buttonSize;
		[Abstract]
		[Export ("buttonSize", ArgumentSemantic.Assign)]
		MSFPersonaButtonSize ButtonSize { get; set; }

		// @required @property (copy, nonatomic) void (^ _Nullable)(void) onTapAction;
		[Abstract]
		[NullAllowed, Export ("onTapAction", ArgumentSemantic.Copy)]
		Action OnTapAction { get; set; }

		// @required @property (nonatomic) BOOL hasPointerInteraction;
		[Abstract]
		[Export ("hasPointerInteraction")]
		bool HasPointerInteraction { get; set; }

		// @required @property (nonatomic) BOOL hasRingInnerGap;
		[Abstract]
		[Export ("hasRingInnerGap")]
		bool HasRingInnerGap { get; set; }

		// @required @property (nonatomic) BOOL isTransparent;
		[Abstract]
		[Export ("isTransparent")]
		bool IsTransparent { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nullable avatarBackgroundColor;
		[Abstract]
		[NullAllowed, Export ("avatarBackgroundColor", ArgumentSemantic.Strong)]
		UIColor AvatarBackgroundColor { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nullable avatarForegroundColor;
		[Abstract]
		[NullAllowed, Export ("avatarForegroundColor", ArgumentSemantic.Strong)]
		UIColor AvatarForegroundColor { get; set; }

		// @required @property (nonatomic, strong) UIImage * _Nullable image;
		[Abstract]
		[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @required @property (nonatomic, strong) UIImage * _Nullable imageBasedRingColor;
		[Abstract]
		[NullAllowed, Export ("imageBasedRingColor", ArgumentSemantic.Strong)]
		UIImage ImageBasedRingColor { get; set; }

		// @required @property (nonatomic) BOOL isOutOfOffice;
		[Abstract]
		[Export ("isOutOfOffice")]
		bool IsOutOfOffice { get; set; }

		// @required @property (nonatomic) BOOL isRingVisible;
		[Abstract]
		[Export ("isRingVisible")]
		bool IsRingVisible { get; set; }

		// @required @property (nonatomic) enum MSFAvatarPresence presence;
		[Abstract]
		[Export ("presence", ArgumentSemantic.Assign)]
		MSFAvatarPresence Presence { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable primaryText;
		[Abstract]
		[NullAllowed, Export ("primaryText")]
		string PrimaryText { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nullable ringColor;
		[Abstract]
		[NullAllowed, Export ("ringColor", ArgumentSemantic.Strong)]
		UIColor RingColor { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable secondaryText;
		[Abstract]
		[NullAllowed, Export ("secondaryText")]
		string SecondaryText { get; set; }
	}

// 	// @protocol MSFPersonaCarouselButtonState
// 	/*
//   Check whether adding [Model] to this declaration is appropriate.
//   [Model] is used to generate a C# class that implements this protocol,
//   and might be useful for protocols that consumers are supposed to implement,
//   since consumers can subclass the generated class instead of implementing
//   the generated interface. If consumers are not supposed to implement this
//   protocol, then [Model] is redundant and will generate code that will never
//   be used.
// */
    [Protocol (Name = "_TtP8FluentUI29MSFPersonaCarouselButtonState_")]
     [BaseType (typeof(NSObject))]
	interface MSFPersonaCarouselButtonState
	{
		// @required @property (nonatomic, strong) UIColor * _Nullable avatarBackgroundColor;
		[Abstract]
		[NullAllowed, Export ("avatarBackgroundColor", ArgumentSemantic.Strong)]
		UIColor AvatarBackgroundColor { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nullable avatarForegroundColor;
		[Abstract]
		[NullAllowed, Export ("avatarForegroundColor", ArgumentSemantic.Strong)]
		UIColor AvatarForegroundColor { get; set; }

		// @required @property (nonatomic, strong) UIImage * _Nullable image;
		[Abstract]
		[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @required @property (nonatomic, strong) UIImage * _Nullable imageBasedRingColor;
		[Abstract]
		[NullAllowed, Export ("imageBasedRingColor", ArgumentSemantic.Strong)]
		UIImage ImageBasedRingColor { get; set; }

		// @required @property (nonatomic) BOOL isOutOfOffice;
		[Abstract]
		[Export ("isOutOfOffice")]
		bool IsOutOfOffice { get; set; }

		// @required @property (nonatomic) BOOL isRingVisible;
		[Abstract]
		[Export ("isRingVisible")]
		bool IsRingVisible { get; set; }

		// @required @property (nonatomic) enum MSFAvatarPresence presence;
		[Abstract]
		[Export ("presence", ArgumentSemantic.Assign)]
		MSFAvatarPresence Presence { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable primaryText;
		[Abstract]
		[NullAllowed, Export ("primaryText")]
		string PrimaryText { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nullable ringColor;
		[Abstract]
		[NullAllowed, Export ("ringColor", ArgumentSemantic.Strong)]
		UIColor RingColor { get; set; }

		// @required @property (copy, nonatomic) NSString * _Nullable secondaryText;
		[Abstract]
		[NullAllowed, Export ("secondaryText")]
		string SecondaryText { get; set; }
	}

// 	// @interface MSFNavigationBar : UINavigationBar
	[BaseType (typeof(UINavigationBar))]
	interface MSFNavigationBar
	{
		// @property (nonatomic, strong) id<MSFPersona> _Nullable personaData;
		[NullAllowed, Export ("personaData", ArgumentSemantic.Strong)]
		MSFPersona PersonaData { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable avatarCustomAccessibilityLabel;
		[NullAllowed, Export ("avatarCustomAccessibilityLabel")]
		string AvatarCustomAccessibilityLabel { get; set; }

		// @property (nonatomic) enum MSFNavigationBarElementSize avatarSize;
		[Export ("avatarSize", ArgumentSemantic.Assign)]
		MSFNavigationBarElementSize AvatarSize { get; set; }

		// -(UIView * _Nullable)visibleAvatarView __attribute__((warn_unused_result("")));
		[NullAllowed, Export ("visibleAvatarView")]
		// [Verify (MethodToProperty)]
		UIView VisibleAvatarView { get; }

		// -(UIView * _Nullable)barButtonItemViewWith:(NSInteger)tag __attribute__((warn_unused_result("")));
		[Export ("barButtonItemViewWith:")]
		[return: NullAllowed]
		UIView BarButtonItemViewWith (nint tag);

		// @property (readonly, nonatomic) enum MSFNavigationBarElementSize barHeight;
		[Export ("barHeight")]
		MSFNavigationBarElementSize BarHeight { get; }

		// @property (nonatomic) enum MSFNavigationBarElementSize titleSize;
		[Export ("titleSize", ArgumentSemantic.Assign)]
		MSFNavigationBarElementSize TitleSize { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(void) onAvatarTapped;
		[NullAllowed, Export ("onAvatarTapped", ArgumentSemantic.Copy)]
		Action OnAvatarTapped { get; set; }

		// @property (readonly, nonatomic, class) CGFloat defaultContentLeadingMargin;
		[Static]
		[Export ("defaultContentLeadingMargin")]
		nfloat DefaultContentLeadingMargin { get; }

		// @property (readonly, nonatomic, class) CGFloat defaultContentTrailingMargin;
		[Static]
		[Export ("defaultContentTrailingMargin")]
		nfloat DefaultContentTrailingMargin { get; }

		// @property (nonatomic) CGFloat contentLeadingMargin;
		[Export ("contentLeadingMargin")]
		nfloat ContentLeadingMargin { get; set; }

		// @property (nonatomic) CGFloat contentTrailingMargin;
		[Export ("contentTrailingMargin")]
		nfloat ContentTrailingMargin { get; set; }

		// @property (nonatomic) CGPoint center;
		[Export ("center", ArgumentSemantic.Assign)]
		CGPoint Center { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)didMoveToWindow;
		[Export ("didMoveToWindow")]
		void DidMoveToWindow ();

		// -(BOOL)pointInside:(CGPoint)point withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result("")));
		[Export ("pointInside:withEvent:")]
		bool PointInside (CGPoint point, [NullAllowed] UIEvent @event);

		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);

		// -(void)overrideAvatarWith:(enum MSFAvatarStyle)style;
		[Export ("overrideAvatarWith:")]
		void OverrideAvatarWith (MSFAvatarStyle style);
	}

// 	// @interface MSFNavigationBarTopAccessoryViewAttributes : NSObject
	[BaseType (typeof(NSObject))]
	interface MSFNavigationBarTopAccessoryViewAttributes
	{
		// @property (readonly, nonatomic) CGFloat widthMultiplier;
		[Export ("widthMultiplier")]
		nfloat WidthMultiplier { get; }

		// @property (readonly, nonatomic) CGFloat maxWidth;
		[Export ("maxWidth")]
		nfloat MaxWidth { get; }

		// @property (readonly, nonatomic) CGFloat minWidth;
		[Export ("minWidth")]
		nfloat MinWidth { get; }

		// -(instancetype _Nonnull)initWithWidthMultiplier:(CGFloat)widthMultiplier maxWidth:(CGFloat)maxWidth minWidth:(CGFloat)minWidth __attribute__((objc_designated_initializer));
		[Export ("initWithWidthMultiplier:maxWidth:minWidth:")]
		[DesignatedInitializer]
		NativeHandle Constructor (nfloat widthMultiplier, nfloat maxWidth, nfloat minWidth);
	}

// 	// @interface MSFNavigationBarTopSearchBarAttributes : MSFNavigationBarTopAccessoryViewAttributes
	[BaseType (typeof(MSFNavigationBarTopAccessoryViewAttributes))]
	interface MSFNavigationBarTopSearchBarAttributes
	{
	}

// 	// @interface MSFNavigationController : UINavigationController
	[BaseType (typeof(UINavigationController))]
	interface MSFNavigationController
	{
		// @property (nonatomic) BOOL allowResizeOfNavigationBarOnScroll;
		[Export ("allowResizeOfNavigationBarOnScroll")]
		bool AllowResizeOfNavigationBarOnScroll { get; set; }

		// @property (readonly, nonatomic, strong) MSFNavigationBar * _Nonnull msfNavigationBar;
		[Export ("msfNavigationBar", ArgumentSemantic.Strong)]
		MSFNavigationBar MsfNavigationBar { get; }

		// @property (readonly, nonatomic, strong) UIViewController * _Nullable topContentViewController;
		[NullAllowed, Export ("topContentViewController", ArgumentSemantic.Strong)]
		UIViewController TopContentViewController { get; }

		// @property (readonly, nonatomic, strong) UIViewController * _Nullable childViewControllerForStatusBarStyle;
		[NullAllowed, Export ("childViewControllerForStatusBarStyle", ArgumentSemantic.Strong)]
		UIViewController ChildViewControllerForStatusBarStyle { get; }

		// @property (readonly, nonatomic) UIStatusBarStyle preferredStatusBarStyle;
		[Export ("preferredStatusBarStyle")]
		UIStatusBarStyle PreferredStatusBarStyle { get; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		UINavigationControllerDelegate Delegate { get; set; }

		// @property (nonatomic, strong) id<UINavigationControllerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Strong)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype _Nonnull)initWithNavigationBarClass:(Class _Nullable)navigationBarClass toolbarClass:(Class _Nullable)toolbarClass __attribute__((objc_designated_initializer));
		[Export ("initWithNavigationBarClass:toolbarClass:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] Class navigationBarClass, [NullAllowed] Class toolbarClass);

		// -(instancetype _Nonnull)initWithRootViewController:(UIViewController * _Nonnull)rootViewController;
		[Export ("initWithRootViewController:")]
		NativeHandle Constructor (UIViewController rootViewController);

		// -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
		[Export ("initWithNibName:bundle:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// -(void)viewDidLoad;
		[Export ("viewDidLoad")]
		void ViewDidLoad ();

		// -(void)viewWillLayoutSubviews;
		[Export ("viewWillLayoutSubviews")]
		void ViewWillLayoutSubviews ();

		// -(void)pushViewController:(UIViewController * _Nonnull)viewController animated:(BOOL)animated;
		[Export ("pushViewController:animated:")]
		void PushViewController (UIViewController viewController, bool animated);

		// -(void)setViewControllers:(NSArray<UIViewController *> * _Nonnull)viewControllers animated:(BOOL)animated;
		[Export ("setViewControllers:animated:")]
		void SetViewControllers (UIViewController[] viewControllers, bool animated);

		// -(void)expandNavigationBarWithAnimated:(BOOL)animated;
		[Export ("expandNavigationBarWithAnimated:")]
		void ExpandNavigationBarWithAnimated (bool animated);

		// -(void)contractNavigationBarWithAnimated:(BOOL)animated;
		[Export ("contractNavigationBarWithAnimated:")]
		void ContractNavigationBarWithAnimated (bool animated);

		// -(UIViewController * _Nonnull)contentViewControllerFor:(UIViewController * _Nonnull)controller __attribute__((warn_unused_result("")));
		[Export ("contentViewControllerFor:")]
		UIViewController ContentViewControllerFor (UIViewController controller);

		// -(void)setNavigationBarHidden:(BOOL)hidden animated:(BOOL)animated;
		[Export ("setNavigationBarHidden:animated:")]
		void SetNavigationBarHidden (bool hidden, bool animated);
	}

// 	// @interface FluentUI_Swift_3297 (MSFNavigationController) <UINavigationControllerDelegate>
// 	[Category]
// 	[BaseType (typeof(MSFNavigationController))]
// 	interface MSFNavigationController_FluentUI_Swift_3297 : IUINavigationControllerDelegate
// 	{
// 		// -(void)navigationController:(UINavigationController * _Nonnull)navigationController willShowViewController:(UIViewController * _Nonnull)viewController animated:(BOOL)animated;
// 		[Export ("navigationController:willShowViewController:animated:")]
// 		void NavigationController (UINavigationController navigationController, UIViewController viewController, bool animated);

// 		// -(void)navigationController:(UINavigationController * _Nonnull)navigationController didShowViewController:(UIViewController * _Nonnull)viewController animated:(BOOL)animated;
// 		[Export ("navigationController:didShowViewController:animated:")]
// 		void NavigationController (UINavigationController navigationController, UIViewController viewController, bool animated);

// 		// -(UIInterfaceOrientationMask)navigationControllerSupportedInterfaceOrientations:(UINavigationController * _Nonnull)navigationController __attribute__((warn_unused_result("")));
// 		[Export ("navigationControllerSupportedInterfaceOrientations:")]
// 		UIInterfaceOrientationMask NavigationControllerSupportedInterfaceOrientations (UINavigationController navigationController);

// 		// -(id<UIViewControllerInteractiveTransitioning> _Nullable)navigationController:(UINavigationController * _Nonnull)navigationController interactionControllerForAnimationController:(id<UIViewControllerAnimatedTransitioning> _Nonnull)animationController __attribute__((warn_unused_result("")));
// 		[Export ("navigationController:interactionControllerForAnimationController:")]
// 		[return: NullAllowed]
// 		UIViewControllerInteractiveTransitioning NavigationController (UINavigationController navigationController, UIViewControllerAnimatedTransitioning animationController);

// 		// -(id<UIViewControllerAnimatedTransitioning> _Nullable)navigationController:(UINavigationController * _Nonnull)navigationController animationControllerForOperation:(UINavigationControllerOperation)operation fromViewController:(UIViewController * _Nonnull)fromVC toViewController:(UIViewController * _Nonnull)toVC __attribute__((warn_unused_result("")));
// 		[Export ("navigationController:animationControllerForOperation:fromViewController:toViewController:")]
// 		[return: NullAllowed]
// 		UIViewControllerAnimatedTransitioning NavigationController (UINavigationController navigationController, UINavigationControllerOperation operation, UIViewController fromVC, UIViewController toVC);
// 	}

// 	// @interface MSFPageCardPresenterController : UIViewController
	[BaseType (typeof(UIViewController))]
	interface MSFPageCardPresenterController
	{
		// @property (nonatomic) UIModalPresentationStyle modalPresentationStyle;
		[Export ("modalPresentationStyle", ArgumentSemantic.Assign)]
		UIModalPresentationStyle ModalPresentationStyle { get; set; }

		[Wrap ("WeakTransitioningDelegate")]
		[NullAllowed]
		UIViewControllerTransitioningDelegate TransitioningDelegate { get; set; }

		// @property (nonatomic, strong) id<UIViewControllerTransitioningDelegate> _Nullable transitioningDelegate;
		[NullAllowed, Export ("transitioningDelegate", ArgumentSemantic.Strong)]
		NSObject WeakTransitioningDelegate { get; set; }

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// -(void)viewDidLoad;
		[Export ("viewDidLoad")]
		void ViewDidLoad ();

		// -(void)viewWillAppear:(BOOL)animated;
		[Export ("viewWillAppear:")]
		void ViewWillAppear (bool animated);

		// -(void)viewWillLayoutSubviews;
		[Export ("viewWillLayoutSubviews")]
		void ViewWillLayoutSubviews ();
	}

// 	// @interface FluentUI_Swift_3324 (MSFPageCardPresenterController) <UIScrollViewDelegate>
// 	[Category]
// 	[BaseType (typeof(MSFPageCardPresenterController))]
// 	interface MSFPageCardPresenterController_FluentUI_Swift_3324 : IUIScrollViewDelegate
// 	{
// 		// -(void)scrollViewWillEndDragging:(UIScrollView * _Nonnull)scrollView withVelocity:(CGPoint)velocity targetContentOffset:(CGPoint * _Nonnull)targetContentOffset;
// 		[Export ("scrollViewWillEndDragging:withVelocity:targetContentOffset:")]
// 		unsafe void ScrollViewWillEndDragging (UIScrollView scrollView, CGPoint velocity, CGPoint* targetContentOffset);

// 		// -(void)scrollViewDidEndDecelerating:(UIScrollView * _Nonnull)scrollView;
// 		[Export ("scrollViewDidEndDecelerating:")]
// 		void ScrollViewDidEndDecelerating (UIScrollView scrollView);

// 		// -(void)scrollViewDidEndDragging:(UIScrollView * _Nonnull)scrollView willDecelerate:(BOOL)decelerate;
// 		[Export ("scrollViewDidEndDragging:willDecelerate:")]
// 		void ScrollViewDidEndDragging (UIScrollView scrollView, bool decelerate);
// 	}

// 	// @interface FluentUI_Swift_3331 (MSFPageCardPresenterController) <UIViewControllerTransitioningDelegate>
// 	[Category]
// 	[BaseType (typeof(MSFPageCardPresenterController))]
// 	interface MSFPageCardPresenterController_FluentUI_Swift_3331 : IUIViewControllerTransitioningDelegate
// 	{
// 		// -(id<UIViewControllerAnimatedTransitioning> _Nullable)animationControllerForPresentedController:(UIViewController * _Nonnull)presented presentingController:(UIViewController * _Nonnull)presenting sourceController:(UIViewController * _Nonnull)source __attribute__((warn_unused_result("")));
// 		[Export ("animationControllerForPresentedController:presentingController:sourceController:")]
// 		[return: NullAllowed]
// 		UIViewControllerAnimatedTransitioning AnimationControllerForPresentedController (UIViewController presented, UIViewController presenting, UIViewController source);

// 		// -(id<UIViewControllerAnimatedTransitioning> _Nullable)animationControllerForDismissedController:(UIViewController * _Nonnull)dismissed __attribute__((warn_unused_result("")));
// 		[Export ("animationControllerForDismissedController:")]
// 		[return: NullAllowed]
// 		UIViewControllerAnimatedTransitioning AnimationControllerForDismissedController (UIViewController dismissed);

// 		// -(UIPresentationController * _Nullable)presentationControllerForPresentedViewController:(UIViewController * _Nonnull)presented presentingViewController:(UIViewController * _Nullable)presenting sourceViewController:(UIViewController * _Nonnull)source __attribute__((warn_unused_result("")));
// 		[Export ("presentationControllerForPresentedViewController:presentingViewController:sourceViewController:")]
// 		[return: NullAllowed]
// 		UIPresentationController PresentationControllerForPresentedViewController (UIViewController presented, [NullAllowed] UIViewController presenting, UIViewController source);
// 	}

// 	// @interface MSFPeoplePicker : MSFBadgeField
	[BaseType (typeof(MSFBadgeField))]
	interface MSFPeoplePicker
	{
		// @property (copy, nonatomic) NSArray<id<MSFPersona>> * _Nonnull availablePersonas;
		[Export ("availablePersonas", ArgumentSemantic.Copy)]
		MSFPersona[] AvailablePersonas { get; set; }

		// @property (copy, nonatomic) NSArray<id<MSFPersona>> * _Nonnull pickedPersonas;
		[Export ("pickedPersonas", ArgumentSemantic.Copy)]
		MSFPersona[] PickedPersonas { get; set; }

		// @property (nonatomic) BOOL showsSearchDirectoryButton;
		[Export ("showsSearchDirectoryButton")]
		bool ShowsSearchDirectoryButton { get; set; }

		// @property (nonatomic) BOOL allowsPickedPersonasToAppearAsSuggested;
		[Export ("allowsPickedPersonasToAppearAsSuggested")]
		bool AllowsPickedPersonasToAppearAsSuggested { get; set; }

		// @property (nonatomic) BOOL hidePersonaListViewWhenNoSuggestedPersonas;
		[Export ("hidePersonaListViewWhenNoSuggestedPersonas")]
		bool HidePersonaListViewWhenNoSuggestedPersonas { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MSFPeoplePickerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MSFPeoplePickerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic, strong) UIView * _Nonnull personaSuggestionsView;
		[Export ("personaSuggestionsView", ArgumentSemantic.Strong)]
		UIView PersonaSuggestionsView { get; }

		// @property (readonly, nonatomic, strong) MSFPersonaListView * _Nonnull personaListView;
		[Export ("personaListView", ArgumentSemantic.Strong)]
		MSFPersonaListView PersonaListView { get; }

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// -(MSFBadgeView * _Nullable)badgeFor:(id<MSFPersona> _Nonnull)persona __attribute__((warn_unused_result("")));
		[Export ("badgeFor:")]
		[return: NullAllowed]
		MSFBadgeView BadgeFor (MSFPersona persona);

		// -(void)willMoveToWindow:(UIWindow * _Nullable)newWindow;
		[Export ("willMoveToWindow:")]
		void WillMoveToWindow ([NullAllowed] UIWindow newWindow);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)showPersonaSuggestions;
		[Export ("showPersonaSuggestions")]
		void ShowPersonaSuggestions ();

		// -(void)hidePersonaSuggestions;
		[Export ("hidePersonaSuggestions")]
		void HidePersonaSuggestions ();

		// -(void)badgeText;
		[Export ("badgeText")]
		void BadgeText ();

		// -(void)addBadgeWithDataSource:(MSFBadgeViewDataSource * _Nonnull)dataSource fromUserAction:(BOOL)fromUserAction updateConstrainedBadges:(BOOL)updateConstrainedBadges;
		[Export ("addBadgeWithDataSource:fromUserAction:updateConstrainedBadges:")]
		void AddBadgeWithDataSource (MSFBadgeViewDataSource dataSource, bool fromUserAction, bool updateConstrainedBadges);

		// -(void)resetTextFieldContent;
		[Export ("resetTextFieldContent")]
		void ResetTextFieldContent ();

		// -(void)textFieldDidEndEditing:(UITextField * _Nonnull)textField;
		[Export ("textFieldDidEndEditing:")]
		void TextFieldDidEndEditing (UITextField textField);

		// -(void)didSelectBadge:(MSFBadgeView * _Nonnull)badge;
		[Export ("didSelectBadge:")]
		void DidSelectBadge (MSFBadgeView badge);

		// -(void)didTapSelectedBadge:(MSFBadgeView * _Nonnull)badge;
		[Export ("didTapSelectedBadge:")]
		void DidTapSelectedBadge (MSFBadgeView badge);
	}

// 	// @protocol MSFPersonaListViewSearchDirectoryDelegate
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MSFPersonaListViewSearchDirectoryDelegate
	{
		// @required -(void)personaListSearchDirectory:(MSFPersonaListView * _Nonnull)personaListView completion:(void (^ _Nonnull)(BOOL))completion;
		[Abstract]
		[Export ("personaListSearchDirectory:completion:")]
		void Completion (MSFPersonaListView personaListView, Action<bool> completion);
	}

// 	// @interface FluentUI_Swift_3388 (MSFPeoplePicker) <MSFPersonaListViewSearchDirectoryDelegate>
// 	[Category]
// 	[BaseType (typeof(MSFPeoplePicker))]
// 	interface MSFPeoplePicker_FluentUI_Swift_3388 : IMSFPersonaListViewSearchDirectoryDelegate
// 	{
// 		// -(void)personaListSearchDirectory:(MSFPersonaListView * _Nonnull)personaListView completion:(void (^ _Nonnull)(BOOL))completion;
// 		[Export ("personaListSearchDirectory:completion:")]
// 		void PersonaListSearchDirectory (MSFPersonaListView personaListView, Action<bool> completion);
// 	}

// 	// @protocol MSFPeoplePickerDelegate <MSFBadgeFieldDelegate>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MSFPeoplePickerDelegate : MSFBadgeFieldDelegate
	{
		// @optional -(void)peoplePicker:(MSFPeoplePicker * _Nonnull)peoplePicker getSuggestedPersonasForText:(NSString * _Nonnull)text completion:(void (^ _Nonnull)(NSArray<id<MSFPersona>> * _Nonnull))completion;
		[Export ("peoplePicker:getSuggestedPersonasForText:completion:")]
		void GetSuggestedPersonasForText (MSFPeoplePicker peoplePicker, string text, Action<MSFPersona[]> completion);

		// @optional -(BOOL)peoplePicker:(MSFPeoplePicker * _Nonnull)peoplePicker shouldPickPersona:(id<MSFPersona> _Nonnull)persona __attribute__((warn_unused_result("")));
		[Export ("peoplePicker:shouldPickPersona:")]
		bool ShouldPickPersona (MSFPeoplePicker peoplePicker, MSFPersona persona);

		// @optional -(void)peoplePicker:(MSFPeoplePicker * _Nonnull)peoplePicker didPickPersona:(id<MSFPersona> _Nonnull)persona;
		[Export ("peoplePicker:didPickPersona:")]
		void DidPickPersona (MSFPeoplePicker peoplePicker, MSFPersona persona);

		// @optional -(id<MSFPersona> _Nonnull)peoplePicker:(MSFPeoplePicker * _Nonnull)peoplePicker personaFromText:(NSString * _Nonnull)text __attribute__((warn_unused_result("")));
		[Export ("peoplePicker:personaFromText:")]
		MSFPersona PersonaFromText (MSFPeoplePicker peoplePicker, string text);

		// @optional -(BOOL)peoplePicker:(MSFPeoplePicker * _Nonnull)peoplePicker personaIsValid:(id<MSFPersona> _Nonnull)persona __attribute__((warn_unused_result("")));
		[Export ("peoplePicker:personaIsValid:")]
		bool PersonaIsValid (MSFPeoplePicker peoplePicker, MSFPersona persona);

		// @optional -(void)peoplePicker:(MSFPeoplePicker * _Nonnull)peoplePicker didSelectPersona:(id<MSFPersona> _Nonnull)persona;
		[Export ("peoplePicker:didSelectPersona:")]
		void PeoplePicker (MSFPeoplePicker peoplePicker, MSFPersona persona);

		// @optional -(void)peoplePicker:(MSFPeoplePicker * _Nonnull)peoplePicker didTapSelectedPersona:(id<MSFPersona> _Nonnull)persona;
		[Export ("peoplePicker:didTapSelectedPersona:")]
		void DidTapSelectedPersona (MSFPeoplePicker peoplePicker, MSFPersona persona);

		// @optional -(void)peoplePicker:(MSFPeoplePicker * _Nonnull)peoplePicker didRemovePersona:(id<MSFPersona> _Nonnull)persona;
		[Export ("peoplePicker:didRemovePersona:")]
		void DidRemovePersona (MSFPeoplePicker peoplePicker, MSFPersona persona);

		// @optional -(void)peoplePicker:(MSFPeoplePicker * _Nonnull)peoplePicker searchDirectoryWithCompletion:(void (^ _Nonnull)(NSArray<id<MSFPersona>> * _Nonnull, BOOL))completion;
		[Export ("peoplePicker:searchDirectoryWithCompletion:")]
		void SearchDirectoryWithCompletion (MSFPeoplePicker peoplePicker, Action<MSFPersona[], bool> completion);

		// @optional -(BOOL)peoplePickerShouldKeepShowingPersonaSuggestionsOnEndEditing:(MSFPeoplePicker * _Nonnull)peoplePicker __attribute__((warn_unused_result("")));
		[Export ("peoplePickerShouldKeepShowingPersonaSuggestionsOnEndEditing:")]
		bool PeoplePickerShouldKeepShowingPersonaSuggestionsOnEndEditing (MSFPeoplePicker peoplePicker);

		// @optional -(void)peoplePickerDidShowPersonaSuggestions:(MSFPeoplePicker * _Nonnull)peoplePicker;
		[Export ("peoplePickerDidShowPersonaSuggestions:")]
		void PeoplePickerDidShowPersonaSuggestions (MSFPeoplePicker peoplePicker);

		// @optional -(void)peoplePickerDidHidePersonaSuggestions:(MSFPeoplePicker * _Nonnull)peoplePicker;
		[Export ("peoplePickerDidHidePersonaSuggestions:")]
		void PeoplePickerDidHidePersonaSuggestions (MSFPeoplePicker peoplePicker);
	}

// 	// @protocol MSFPersona
// 	/*
//   Check whether adding [Model] to this declaration is appropriate.
//   [Model] is used to generate a C# class that implements this protocol,
//   and might be useful for protocols that consumers are supposed to implement,
//   since consumers can subclass the generated class instead of implementing
//   the generated interface. If consumers are not supposed to implement this
//   protocol, then [Model] is redundant and will generate code that will never
//   be used.
// */
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
	interface MSFPersona
	{
		// @required @property (readonly, nonatomic, strong) UIImage * _Nullable image;
		[Abstract]
		[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; }

		// @required @property (readonly, nonatomic, strong) UIColor * _Nullable color;
		[Abstract]
		[NullAllowed, Export ("color", ArgumentSemantic.Strong)]
		UIColor Color { get; }

		// @required @property (readonly, nonatomic, strong) UIImage * _Nullable imageBasedRingColor;
		[Abstract]
		[NullAllowed, Export ("imageBasedRingColor", ArgumentSemantic.Strong)]
		UIImage ImageBasedRingColor { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull email;
		[Abstract]
		[Export ("email")]
		string Email { get; }

		// @required @property (readonly, nonatomic) BOOL hasRingInnerGap;
		[Abstract]
		[Export ("hasRingInnerGap")]
		bool HasRingInnerGap { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Abstract]
		[Export ("name")]
		string Name { get; }

		// @required @property (readonly, nonatomic) enum MSFAvatarPresence presence;
		[Abstract]
		[Export ("presence")]
		MSFAvatarPresence Presence { get; }

		// @required @property (nonatomic) BOOL isOutOfOffice;
		[Abstract]
		[Export ("isOutOfOffice")]
		bool IsOutOfOffice { get; set; }

		// @required @property (readonly, nonatomic) BOOL isRingVisible;
		[Abstract]
		[Export ("isRingVisible")]
		bool IsRingVisible { get; }

		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull subtitle;
		[Abstract]
		[Export ("subtitle")]
		string Subtitle { get; }

		// @optional -(void)fetchImageWithCompletion:(void (^ _Nonnull)(UIImage * _Nullable))completion;
		[Export ("fetchImageWithCompletion:")]
		void FetchImageWithCompletion (Action<UIImage> completion);
	}

// 	// @interface MSFPersonaBadgeViewDataSource : MSFBadgeViewDataSource
	[BaseType (typeof(MSFBadgeViewDataSource))]
	interface MSFPersonaBadgeViewDataSource
	{
		// @property (nonatomic, strong) id<MSFPersona> _Nonnull persona;
		[Export ("persona", ArgumentSemantic.Strong)]
		MSFPersona Persona { get; set; }

		// -(instancetype _Nonnull)initWithPersona:(id<MSFPersona> _Nonnull)persona style:(enum MSFBadgeViewStyle)style size:(enum MSFBadgeViewSize)size __attribute__((objc_designated_initializer));
		[Export ("initWithPersona:style:size:")]
		[DesignatedInitializer]
		NativeHandle Constructor (MSFPersona persona, MSFBadgeViewStyle style, MSFBadgeViewSize size);
	}

// 	// @interface MSFPersonaCell : MSFTableViewCell
	[BaseType (typeof(MSFTableViewCell))]
	interface MSFPersonaCell
	{
		// @property (nonatomic) enum MSFTableViewCellCustomViewSize customViewSize;
		[Export ("customViewSize", ArgumentSemantic.Assign)]
		MSFTableViewCellCustomViewSize CustomViewSize { get; set; }

		// -(void)setupWithPersona:(id<MSFPersona> _Nonnull)persona accessoryType:(enum MSFTableViewCellAccessoryType)accessoryType;
		[Export ("setupWithPersona:accessoryType:")]
		void SetupWithPersona (MSFPersona persona, MSFTableViewCellAccessoryType accessoryType);

		// -(instancetype _Nonnull)initWithStyle:(UITableViewCellStyle)style reuseIdentifier:(NSString * _Nullable)reuseIdentifier __attribute__((objc_designated_initializer));
		[Export ("initWithStyle:reuseIdentifier:")]
		[DesignatedInitializer]
		NativeHandle Constructor (UITableViewCellStyle style, [NullAllowed] string reuseIdentifier);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);
	}

// 	// @interface MSFPersonaData : NSObject <MSFPersona>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MSFPersonaData : MSFPersona
	{
		// @property (nonatomic, strong) UIImage * _Nullable image;
		[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull email;
		[Export ("email")]
		string Email { get; set; }

		// @property (nonatomic, strong) UIImage * _Nullable imageBasedRingColor;
		[NullAllowed, Export ("imageBasedRingColor", ArgumentSemantic.Strong)]
		UIImage ImageBasedRingColor { get; set; }

		// @property (nonatomic) BOOL hasRingInnerGap;
		[Export ("hasRingInnerGap")]
		bool HasRingInnerGap { get; set; }

		// @property (nonatomic) BOOL isRingVisible;
		[Export ("isRingVisible")]
		bool IsRingVisible { get; set; }

		// @property (nonatomic) BOOL isOutOfOffice;
		[Export ("isOutOfOffice")]
		bool IsOutOfOffice { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable color;
		[NullAllowed, Export ("color", ArgumentSemantic.Strong)]
		UIColor Color { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull subtitle;
		[Export ("subtitle")]
		string Subtitle { get; set; }

		// @property (nonatomic) enum MSFAvatarPresence presence;
		[Export ("presence", ArgumentSemantic.Assign)]
		MSFAvatarPresence Presence { get; set; }

		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name email:(NSString * _Nonnull)email subtitle:(NSString * _Nonnull)subtitle image:(UIImage * _Nullable)image presence:(enum MSFAvatarPresence)presence color:(UIColor * _Nullable)color __attribute__((objc_designated_initializer));
		[Export ("initWithName:email:subtitle:image:presence:color:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string name, string email, string subtitle, [NullAllowed] UIImage image, MSFAvatarPresence presence, [NullAllowed] UIColor color);

		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name email:(NSString * _Nonnull)email subtitle:(NSString * _Nonnull)subtitle image:(UIImage * _Nullable)image presence:(enum MSFAvatarPresence)presence color:(UIColor * _Nullable)color isRingVisible:(BOOL)isRingVisible __attribute__((objc_designated_initializer));
		[Export ("initWithName:email:subtitle:image:presence:color:isRingVisible:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string name, string email, string subtitle, [NullAllowed] UIImage image, MSFAvatarPresence presence, [NullAllowed] UIColor color, bool isRingVisible);

		// -(instancetype _Nonnull)initWithFirstName:(NSString * _Nonnull)firstName lastName:(NSString * _Nonnull)lastName email:(NSString * _Nonnull)email subtitle:(NSString * _Nonnull)subtitle image:(UIImage * _Nullable)image presence:(enum MSFAvatarPresence)presence color:(UIColor * _Nullable)color __attribute__((objc_designated_initializer));
		[Export ("initWithFirstName:lastName:email:subtitle:image:presence:color:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string firstName, string lastName, string email, string subtitle, [NullAllowed] UIImage image, MSFAvatarPresence presence, [NullAllowed] UIColor color);
	}

// 	// @interface MSFPersonaListView : UITableView
	[BaseType (typeof(UITableView))]
	interface MSFPersonaListView
	{
		// @property (copy, nonatomic) NSArray<id<MSFPersona>> * _Nonnull personaList;
		[Export ("personaList", ArgumentSemantic.Copy)]
		MSFPersona[] PersonaList { get; set; }

		// @property (nonatomic) enum MSFTableViewCellAccessoryType accessoryType;
		[Export ("accessoryType", ArgumentSemantic.Assign)]
		MSFTableViewCellAccessoryType AccessoryType { get; set; }

		// @property (nonatomic) BOOL showsSearchDirectoryButton;
		[Export ("showsSearchDirectoryButton")]
		bool ShowsSearchDirectoryButton { get; set; }

		[Wrap ("WeakSearchDirectoryDelegate")]
		[NullAllowed]
		MSFPersonaListViewSearchDirectoryDelegate SearchDirectoryDelegate { get; set; }

		// @property (nonatomic, weak) id<MSFPersonaListViewSearchDirectoryDelegate> _Nullable searchDirectoryDelegate;
		[NullAllowed, Export ("searchDirectoryDelegate", ArgumentSemantic.Weak)]
		NSObject WeakSearchDirectoryDelegate { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(id<MSFPersona> _Nonnull) onPersonaSelected;
		[NullAllowed, Export ("onPersonaSelected", ArgumentSemantic.Copy)]
		Action<MSFPersona> OnPersonaSelected { get; set; }

		// -(instancetype _Nonnull)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// -(void)pickPersona;
		[Export ("pickPersona")]
		void PickPersona ();

		// -(void)selectPersonaWithDirection:(enum MSFPersonaListViewSelectionDirection)direction;
		[Export ("selectPersonaWithDirection:")]
		void SelectPersonaWithDirection (MSFPersonaListViewSelectionDirection direction);
	}

// 	// @interface FluentUI_Swift_3581 (MSFPersonaListView) <UITableViewDelegate>
// 	[Category]
// 	[BaseType (typeof(MSFPersonaListView))]
// 	interface MSFPersonaListView_FluentUI_Swift_3581 : IUITableViewDelegate
// 	{
// 		// -(void)tableView:(UITableView * _Nonnull)tableView didSelectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
// 		[Export ("tableView:didSelectRowAtIndexPath:")]
// 		void TableView (UITableView tableView, NSIndexPath indexPath);
// 	}

// 	// @interface FluentUI_Swift_3586 (MSFPersonaListView) <UITableViewDataSource>
// 	[Category]
// 	[BaseType (typeof(MSFPersonaListView))]
// 	interface MSFPersonaListView_FluentUI_Swift_3586 : IUITableViewDataSource
// 	{
// 		// -(NSInteger)numberOfSectionsInTableView:(UITableView * _Nonnull)tableView __attribute__((warn_unused_result("")));
// 		[Export ("numberOfSectionsInTableView:")]
// 		nint NumberOfSectionsInTableView (UITableView tableView);

// 		// -(NSInteger)tableView:(UITableView * _Nonnull)tableView numberOfRowsInSection:(NSInteger)section __attribute__((warn_unused_result("")));
// 		[Export ("tableView:numberOfRowsInSection:")]
// 		nint TableView (UITableView tableView, nint section);

// 		// -(UITableViewCell * _Nonnull)tableView:(UITableView * _Nonnull)tableView cellForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result("")));
// 		[Export ("tableView:cellForRowAtIndexPath:")]
// 		UITableViewCell TableView (UITableView tableView, NSIndexPath indexPath);
// 	}

// 	// @interface MSFPillButton : UIButton
	[BaseType (typeof(UIButton))]
	interface MSFPillButton
	{
		// @property (nonatomic, strong) UIColor * _Nullable customBackgroundColor;
		[NullAllowed, Export ("customBackgroundColor", ArgumentSemantic.Strong)]
		UIColor CustomBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable customSelectedBackgroundColor;
		[NullAllowed, Export ("customSelectedBackgroundColor", ArgumentSemantic.Strong)]
		UIColor CustomSelectedBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable customTextColor;
		[NullAllowed, Export ("customTextColor", ArgumentSemantic.Strong)]
		UIColor CustomTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable customSelectedTextColor;
		[NullAllowed, Export ("customSelectedTextColor", ArgumentSemantic.Strong)]
		UIColor CustomSelectedTextColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable customUnreadDotColor;
		[NullAllowed, Export ("customUnreadDotColor", ArgumentSemantic.Strong)]
		UIColor CustomUnreadDotColor { get; set; }

		// -(void)didMoveToWindow;
		[Export ("didMoveToWindow")]
		void DidMoveToWindow ();

		// -(instancetype _Nonnull)initWithPillBarItem:(MSFPillButtonBarItem * _Nonnull)pillBarItem style:(enum MSFPillButtonStyle)style __attribute__((objc_designated_initializer));
		[Export ("initWithPillBarItem:style:")]
		[DesignatedInitializer]
		NativeHandle Constructor (MSFPillButtonBarItem pillBarItem, MSFPillButtonStyle style);

		// @property (readonly, nonatomic, class) CGFloat cornerRadius;
		[Static]
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; }

		// @property (readonly, nonatomic, strong) MSFPillButtonBarItem * _Nonnull pillBarItem;
		[Export ("pillBarItem", ArgumentSemantic.Strong)]
		MSFPillButtonBarItem PillBarItem { get; }

		// @property (readonly, nonatomic) enum MSFPillButtonStyle style;
		[Export ("style")]
		MSFPillButtonStyle Style { get; }

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// @property (getter = isSelected, nonatomic) BOOL selected;
		[Export ("selected")]
		bool Selected { [Bind ("isSelected")] get; set; }

		// @property (getter = isEnabled, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		// @property (getter = isHighlighted, nonatomic) BOOL highlighted;
		[Export ("highlighted")]
		bool Highlighted { [Bind ("isHighlighted")] get; set; }

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();
	}

// 	// @interface FluentUI_Swift_3629 (MSFPillButton)
// 	[Category]
// 	[BaseType (typeof(MSFPillButton))]
// 	interface MSFPillButton_FluentUI_Swift_3629
// 	{
// 		// +(UIColor * _Nonnull)normalBackgroundColorForWindow:(UIWindow * _Nonnull)window ForStyle:(enum MSFPillButtonStyle)style __attribute__((warn_unused_result("")));
// 		[Static]
// 		[Export ("normalBackgroundColorForWindow:ForStyle:")]
// 		UIColor NormalBackgroundColorForWindow (UIWindow window, MSFPillButtonStyle style);
// 	}

// 	// @interface MSFPillButtonBar : UIScrollView
	[BaseType (typeof(UIScrollView))]
	interface MSFPillButtonBar
	{
		[Wrap ("WeakBarDelegate")]
		[NullAllowed]
		MSFPillButtonBarDelegate BarDelegate { get; set; }

		// @property (nonatomic, weak) id<MSFPillButtonBarDelegate> _Nullable barDelegate;
		[NullAllowed, Export ("barDelegate", ArgumentSemantic.Weak)]
		NSObject WeakBarDelegate { get; set; }

		// @property (nonatomic) BOOL centerAligned;
		[Export ("centerAligned")]
		bool CenterAligned { get; set; }

		// @property (copy, nonatomic) NSArray<MSFPillButtonBarItem *> * _Nullable items;
		[NullAllowed, Export ("items", ArgumentSemantic.Copy)]
		MSFPillButtonBarItem[] Items { get; set; }

		// @property (readonly, nonatomic) enum MSFPillButtonStyle pillButtonStyle;
		[Export ("pillButtonStyle")]
		MSFPillButtonStyle PillButtonStyle { get; }

		// @property (nonatomic, strong) MSFPillButtonBarItem * _Nullable selectedItem;
		[NullAllowed, Export ("selectedItem", ArgumentSemantic.Strong)]
		MSFPillButtonBarItem SelectedItem { get; set; }

		// @property (nonatomic) CGRect bounds;
		[Export ("bounds", ArgumentSemantic.Assign)]
		CGRect Bounds { get; set; }

		// -(instancetype _Nonnull)initWithPillButtonStyle:(enum MSFPillButtonStyle)pillButtonStyle;
		[Export ("initWithPillButtonStyle:")]
		NativeHandle Constructor (MSFPillButtonStyle pillButtonStyle);

		// -(instancetype _Nonnull)initWithPillButtonStyle:(enum MSFPillButtonStyle)pillButtonStyle pillButtonBackgroundColor:(UIColor * _Nullable)pillButtonBackgroundColor;
		[Export ("initWithPillButtonStyle:pillButtonBackgroundColor:")]
		NativeHandle Constructor (MSFPillButtonStyle pillButtonStyle, [NullAllowed] UIColor pillButtonBackgroundColor);

		// -(instancetype _Nonnull)initWithPillButtonStyle:(enum MSFPillButtonStyle)pillButtonStyle pillButtonBackgroundColor:(UIColor * _Nullable)pillButtonBackgroundColor selectedPillButtonBackgroundColor:(UIColor * _Nullable)selectedPillButtonBackgroundColor pillButtonTextColor:(UIColor * _Nullable)pillButtonTextColor selectedPillButtonTextColor:(UIColor * _Nullable)selectedPillButtonTextColor pillButtonUnreadDotColor:(UIColor * _Nullable)pillButtonUnreadDotColor;
		[Export ("initWithPillButtonStyle:pillButtonBackgroundColor:selectedPillButtonBackgroundColor:pillButtonTextColor:selectedPillButtonTextColor:pillButtonUnreadDotColor:")]
		NativeHandle Constructor (MSFPillButtonStyle pillButtonStyle, [NullAllowed] UIColor pillButtonBackgroundColor, [NullAllowed] UIColor selectedPillButtonBackgroundColor, [NullAllowed] UIColor pillButtonTextColor, [NullAllowed] UIColor selectedPillButtonTextColor, [NullAllowed] UIColor pillButtonUnreadDotColor);

		// -(instancetype _Nonnull)initWithPillButtonStyle:(enum MSFPillButtonStyle)pillButtonStyle pillButtonBackgroundColor:(UIColor * _Nullable)pillButtonBackgroundColor selectedPillButtonBackgroundColor:(UIColor * _Nullable)selectedPillButtonBackgroundColor pillButtonTextColor:(UIColor * _Nullable)pillButtonTextColor selectedPillButtonTextColor:(UIColor * _Nullable)selectedPillButtonTextColor __attribute__((objc_designated_initializer));
		[Export ("initWithPillButtonStyle:pillButtonBackgroundColor:selectedPillButtonBackgroundColor:pillButtonTextColor:selectedPillButtonTextColor:")]
		[DesignatedInitializer]
		NativeHandle Constructor (MSFPillButtonStyle pillButtonStyle, [NullAllowed] UIColor pillButtonBackgroundColor, [NullAllowed] UIColor selectedPillButtonBackgroundColor, [NullAllowed] UIColor pillButtonTextColor, [NullAllowed] UIColor selectedPillButtonTextColor);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// -(void)selectItem:(MSFPillButtonBarItem * _Nonnull)item;
		[Export ("selectItem:")]
		void SelectItem (MSFPillButtonBarItem item);

		// -(BOOL)selectItemAtIndex:(NSInteger)index __attribute__((warn_unused_result("")));
		[Export ("selectItemAtIndex:")]
		bool SelectItemAtIndex (nint index);

		// -(void)disableItem:(MSFPillButtonBarItem * _Nonnull)item;
		[Export ("disableItem:")]
		void DisableItem (MSFPillButtonBarItem item);

		// -(void)disableItemAtIndex:(NSInteger)index;
		[Export ("disableItemAtIndex:")]
		void DisableItemAtIndex (nint index);

		// -(void)enableItem:(MSFPillButtonBarItem * _Nonnull)item;
		[Export ("enableItem:")]
		void EnableItem (MSFPillButtonBarItem item);

		// -(void)enableItemAtIndex:(NSInteger)index;
		[Export ("enableItemAtIndex:")]
		void EnableItemAtIndex (nint index);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();
	}

// 	// @interface FluentUI_Swift_3702 (MSFPillButtonBar) <UIPointerInteractionDelegate>
// 	[Category]
// 	[BaseType (typeof(MSFPillButtonBar))]
// 	interface MSFPillButtonBar_FluentUI_Swift_3702 : IUIPointerInteractionDelegate
// 	{
// 		// -(UIPointerRegion * _Nullable)pointerInteraction:(UIPointerInteraction * _Nonnull)interaction regionForRequest:(UIPointerRegionRequest * _Nonnull)request defaultRegion:(UIPointerRegion * _Nonnull)defaultRegion __attribute__((warn_unused_result("")));
// 		[Export ("pointerInteraction:regionForRequest:defaultRegion:")]
// 		[return: NullAllowed]
// 		UIPointerRegion PointerInteraction (UIPointerInteraction interaction, UIPointerRegionRequest request, UIPointerRegion defaultRegion);

// 		// -(UIPointerStyle * _Nullable)pointerInteraction:(UIPointerInteraction * _Nonnull)interaction styleForRegion:(UIPointerRegion * _Nonnull)region __attribute__((warn_unused_result("")));
// 		[Export ("pointerInteraction:styleForRegion:")]
// 		[return: NullAllowed]
// 		UIPointerStyle PointerInteraction (UIPointerInteraction interaction, UIPointerRegion region);

// 		// -(void)pointerInteraction:(UIPointerInteraction * _Nonnull)interaction willEnterRegion:(UIPointerRegion * _Nonnull)region animator:(id<UIPointerInteractionAnimating> _Nonnull)animator;
// 		[Export ("pointerInteraction:willEnterRegion:animator:")]
// 		void PointerInteraction (UIPointerInteraction interaction, UIPointerRegion region, UIPointerInteractionAnimating animator);

// 		// -(void)pointerInteraction:(UIPointerInteraction * _Nonnull)interaction willExitRegion:(UIPointerRegion * _Nonnull)region animator:(id<UIPointerInteractionAnimating> _Nonnull)animator __attribute__((swift_name("pointerInteraction(_:willExit:animator:)")));
// 		[Export ("pointerInteraction:willExitRegion:animator:")]
// 		void PointerInteraction (UIPointerInteraction interaction, UIPointerRegion region, UIPointerInteractionAnimating animator);
// 	}

// 	// @protocol MSFPillButtonBarDelegate
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MSFPillButtonBarDelegate
	{
		// @optional -(void)pillBar:(MSFPillButtonBar * _Nonnull)pillBar didSelectItem:(MSFPillButtonBarItem * _Nonnull)item atIndex:(NSInteger)index;
		[Export ("pillBar:didSelectItem:atIndex:")]
		void DidSelectItem (MSFPillButtonBar pillBar, MSFPillButtonBarItem item, nint index);
	}

// 	// @interface MSFPillButtonBarItem : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MSFPillButtonBarItem
	{
		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title __attribute__((objc_designated_initializer));
		[Export ("initWithTitle:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string title);

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title isUnread:(BOOL)isUnread;
		[Export ("initWithTitle:isUnread:")]
		NativeHandle Constructor (string title, bool isUnread);

		// @property (copy, nonatomic) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; set; }
	}

// 	// @interface MSFPopupMenuController : MSFDrawerController
	[BaseType (typeof(MSFDrawerController))]
	interface MSFPopupMenuController
	{
		// @property (nonatomic, strong) UIView * _Nullable contentView;
		[NullAllowed, Export ("contentView", ArgumentSemantic.Strong)]
		UIView ContentView { get; set; }

		// @property (nonatomic) enum MSFDrawerPresentationStyle presentationStyle;
		[Export ("presentationStyle", ArgumentSemantic.Assign)]
		MSFDrawerPresentationStyle PresentationStyle { get; set; }

		// @property (nonatomic) enum MSFDrawerResizingBehavior resizingBehavior;
		[Export ("resizingBehavior", ArgumentSemantic.Assign)]
		MSFDrawerResizingBehavior ResizingBehavior { get; set; }

		// @property (nonatomic) CGSize preferredContentSize;
		[Export ("preferredContentSize", ArgumentSemantic.Assign)]
		CGSize PreferredContentSize { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic, strong) MSFPopupMenuItem * _Nullable headerItem;
		[NullAllowed, Export ("headerItem", ArgumentSemantic.Strong)]
		MSFPopupMenuItem HeaderItem { get; set; }

		// @property (copy, nonatomic) NSIndexPath * _Nullable selectedItemIndexPath;
		[NullAllowed, Export ("selectedItemIndexPath", ArgumentSemantic.Copy)]
		NSIndexPath SelectedItemIndexPath { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull separatorColor;
		[Export ("separatorColor", ArgumentSemantic.Strong)]
		UIColor SeparatorColor { get; set; }

		// -(void)addItems:(NSArray<id<MSFPopupMenuTemplateItem>> * _Nonnull)items;
		[Export ("addItems:")]
		void AddItems (MSFPopupMenuTemplateItem[] items);

		// -(void)addSection:(MSFPopupMenuSection * _Nonnull)section;
		[Export ("addSection:")]
		void AddSection (MSFPopupMenuSection section);

		// -(void)addSections:(NSArray<MSFPopupMenuSection *> * _Nonnull)sections;
		[Export ("addSections:")]
		void AddSections (MSFPopupMenuSection[] sections);

		// -(void)viewDidLoad;
		[Export ("viewDidLoad")]
		void ViewDidLoad ();

		// -(void)viewWillAppear:(BOOL)animated;
		[Export ("viewWillAppear:")]
		void ViewWillAppear (bool animated);

		// -(void)viewDidLayoutSubviews;
		[Export ("viewDidLayoutSubviews")]
		void ViewDidLayoutSubviews ();

		// -(instancetype _Nonnull)initWithSourceView:(UIView * _Nonnull)sourceView sourceRect:(CGRect)sourceRect presentationOrigin:(CGFloat)presentationOrigin presentationDirection:(enum MSFDrawerPresentationDirection)presentationDirection preferredMaximumHeight:(CGFloat)preferredMaximumHeight __attribute__((objc_designated_initializer));
		[Export ("initWithSourceView:sourceRect:presentationOrigin:presentationDirection:preferredMaximumHeight:")]
		[DesignatedInitializer]
		NativeHandle Constructor (UIView sourceView, CGRect sourceRect, nfloat presentationOrigin, MSFDrawerPresentationDirection presentationDirection, nfloat preferredMaximumHeight);

		// -(instancetype _Nonnull)initWithBarButtonItem:(UIBarButtonItem * _Nonnull)barButtonItem presentationOrigin:(CGFloat)presentationOrigin presentationDirection:(enum MSFDrawerPresentationDirection)presentationDirection preferredMaximumHeight:(CGFloat)preferredMaximumHeight __attribute__((objc_designated_initializer));
		[Export ("initWithBarButtonItem:presentationOrigin:presentationDirection:preferredMaximumHeight:")]
		[DesignatedInitializer]
		NativeHandle Constructor (UIBarButtonItem barButtonItem, nfloat presentationOrigin, MSFDrawerPresentationDirection presentationDirection, nfloat preferredMaximumHeight);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);
	}

// 	// @interface FluentUI_Swift_3784 (MSFPopupMenuController) <UITableViewDataSource>
// 	[Category]
// 	[BaseType (typeof(MSFPopupMenuController))]
// 	interface MSFPopupMenuController_FluentUI_Swift_3784 : IUITableViewDataSource
// 	{
// 		// -(NSInteger)numberOfSectionsInTableView:(UITableView * _Nonnull)tableView __attribute__((warn_unused_result("")));
// 		[Export ("numberOfSectionsInTableView:")]
// 		nint NumberOfSectionsInTableView (UITableView tableView);

// 		// -(NSInteger)tableView:(UITableView * _Nonnull)tableView numberOfRowsInSection:(NSInteger)section __attribute__((warn_unused_result("")));
// 		[Export ("tableView:numberOfRowsInSection:")]
// 		nint TableView (UITableView tableView, nint section);

// 		// -(UITableViewCell * _Nonnull)tableView:(UITableView * _Nonnull)tableView cellForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result("")));
// 		[Export ("tableView:cellForRowAtIndexPath:")]
// 		UITableViewCell TableView (UITableView tableView, NSIndexPath indexPath);
// 	}

// 	// @interface FluentUI_Swift_3791 (MSFPopupMenuController) <UITableViewDelegate>
// 	[Category]
// 	[BaseType (typeof(MSFPopupMenuController))]
// 	interface MSFPopupMenuController_FluentUI_Swift_3791 : IUITableViewDelegate
// 	{
// 		// -(CGFloat)tableView:(UITableView * _Nonnull)tableView heightForHeaderInSection:(NSInteger)section __attribute__((warn_unused_result("")));
// 		[Export ("tableView:heightForHeaderInSection:")]
// 		nfloat TableView (UITableView tableView, nint section);

// 		// -(CGFloat)tableView:(UITableView * _Nonnull)tableView heightForFooterInSection:(NSInteger)section __attribute__((warn_unused_result("")));
// 		[Export ("tableView:heightForFooterInSection:")]
// 		nfloat TableView (UITableView tableView, nint section);

// 		// -(UIView * _Nullable)tableView:(UITableView * _Nonnull)tableView viewForHeaderInSection:(NSInteger)section __attribute__((warn_unused_result("")));
// 		[Export ("tableView:viewForHeaderInSection:")]
// 		[return: NullAllowed]
// 		UIView TableView (UITableView tableView, nint section);

// 		// -(UIView * _Nullable)tableView:(UITableView * _Nonnull)tableView viewForFooterInSection:(NSInteger)section __attribute__((warn_unused_result("")));
// 		[Export ("tableView:viewForFooterInSection:")]
// 		[return: NullAllowed]
// 		UIView TableView (UITableView tableView, nint section);

// 		// -(void)tableView:(UITableView * _Nonnull)tableView didSelectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
// 		[Export ("tableView:didSelectRowAtIndexPath:")]
// 		void TableView (UITableView tableView, NSIndexPath indexPath);
// 	}

// 	// @protocol MSFPopupMenuTemplateItem
// 	/*
//   Check whether adding [Model] to this declaration is appropriate.
//   [Model] is used to generate a C# class that implements this protocol,
//   and might be useful for protocols that consumers are supposed to implement,
//   since consumers can subclass the generated class instead of implementing
//   the generated interface. If consumers are not supposed to implement this
//   protocol, then [Model] is redundant and will generate code that will never
//   be used.
// */
[Protocol, Model]
[BaseType (typeof(NSObject))]
	interface MSFPopupMenuTemplateItem
	{
		// @required @property (nonatomic) Class<MSFPopupMenuItemTemplateCell> _Nonnull cellClass;
		[Abstract]
		[Export ("cellClass", ArgumentSemantic.Assign)]
		MSFPopupMenuItemTemplateCell CellClass { get; set; }

		// @required @property (readonly, nonatomic) enum MSFPopupMenuItemExecutionMode executionMode;
		[Abstract]
		[Export ("executionMode")]
		MSFPopupMenuItemExecutionMode ExecutionMode { get; }

		// @required @property (nonatomic) BOOL isSelected;
		[Abstract]
		[Export ("isSelected")]
		bool IsSelected { get; set; }

		// @required @property (readonly, copy, nonatomic) void (^ _Nullable)(void) onSelected;
		[Abstract]
		[NullAllowed, Export ("onSelected", ArgumentSemantic.Copy)]
		Action OnSelected { get; }
	}

// 	// @interface MSFPopupMenuItem : NSObject <MSFPopupMenuTemplateItem>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MSFPopupMenuItem : MSFPopupMenuTemplateItem
	{
		// @property (nonatomic) Class<MSFPopupMenuItemTemplateCell> _Nonnull cellClass;
		[Export ("cellClass", ArgumentSemantic.Assign)]
		MSFPopupMenuItemTemplateCell CellClass { get; set; }

		// @property (readonly, nonatomic, strong) UIImage * _Nullable image;
		[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; }

		// @property (readonly, nonatomic, strong) UIImage * _Nullable selectedImage;
		[NullAllowed, Export ("selectedImage", ArgumentSemantic.Strong)]
		UIImage SelectedImage { get; }

		// @property (readonly, nonatomic, strong) UIImage * _Nullable accessoryImage;
		[NullAllowed, Export ("accessoryImage", ArgumentSemantic.Strong)]
		UIImage AccessoryImage { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable subtitle;
		[NullAllowed, Export ("subtitle")]
		string Subtitle { get; }

		// @property (readonly, nonatomic, strong) UIView * _Nullable accessoryView;
		[NullAllowed, Export ("accessoryView", ArgumentSemantic.Strong)]
		UIView AccessoryView { get; }

		// @property (readonly, nonatomic) enum MSFPopupMenuItemExecutionMode executionMode;
		[Export ("executionMode")]
		MSFPopupMenuItemExecutionMode ExecutionMode { get; }

		// @property (nonatomic) BOOL isEnabled;
		[Export ("isEnabled")]
		bool IsEnabled { get; set; }

		// @property (nonatomic) BOOL isSelected;
		[Export ("isSelected")]
		bool IsSelected { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull titleColor;
		[Export ("titleColor", ArgumentSemantic.Strong)]
		UIColor TitleColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull subtitleColor;
		[Export ("subtitleColor", ArgumentSemantic.Strong)]
		UIColor SubtitleColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull imageColor;
		[Export ("imageColor", ArgumentSemantic.Strong)]
		UIColor ImageColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable titleSelectedColor;
		[NullAllowed, Export ("titleSelectedColor", ArgumentSemantic.Strong)]
		UIColor TitleSelectedColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable subtitleSelectedColor;
		[NullAllowed, Export ("subtitleSelectedColor", ArgumentSemantic.Strong)]
		UIColor SubtitleSelectedColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable imageSelectedColor;
		[NullAllowed, Export ("imageSelectedColor", ArgumentSemantic.Strong)]
		UIColor ImageSelectedColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Strong)]
		UIColor BackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable accessoryCheckmarkColor;
		[NullAllowed, Export ("accessoryCheckmarkColor", ArgumentSemantic.Strong)]
		UIColor AccessoryCheckmarkColor { get; set; }

		// @property (readonly, copy, nonatomic) void (^ _Nullable)(void) onSelected;
		[NullAllowed, Export ("onSelected", ArgumentSemantic.Copy)]
		Action OnSelected { get; }

		// @property (readonly, nonatomic) BOOL isAccessoryCheckmarkVisible;
		[Export ("isAccessoryCheckmarkVisible")]
		bool IsAccessoryCheckmarkVisible { get; }

		// -(instancetype _Nonnull)initWithImage:(UIImage * _Nullable)image selectedImage:(UIImage * _Nullable)selectedImage accessoryImage:(UIImage * _Nullable)accessoryImage title:(NSString * _Nonnull)title subtitle:(NSString * _Nullable)subtitle accessoryView:(UIView * _Nullable)accessoryView isEnabled:(BOOL)isEnabled isSelected:(BOOL)isSelected executes:(enum MSFPopupMenuItemExecutionMode)executionMode onSelected:(void (^ _Nullable)(void))onSelected isAccessoryCheckmarkVisible:(BOOL)isAccessoryCheckmarkVisible __attribute__((objc_designated_initializer));
		[Export ("initWithImage:selectedImage:accessoryImage:title:subtitle:accessoryView:isEnabled:isSelected:executes:onSelected:isAccessoryCheckmarkVisible:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] UIImage image, [NullAllowed] UIImage selectedImage, [NullAllowed] UIImage accessoryImage, string title, [NullAllowed] string subtitle, [NullAllowed] UIView accessoryView, bool isEnabled, bool isSelected, MSFPopupMenuItemExecutionMode executionMode, [NullAllowed] Action onSelected, bool isAccessoryCheckmarkVisible);

		// -(instancetype _Nonnull)initWithImageName:(NSString * _Nonnull)imageName generateSelectedImage:(BOOL)generateSelectedImage title:(NSString * _Nonnull)title subtitle:(NSString * _Nullable)subtitle isEnabled:(BOOL)isEnabled isSelected:(BOOL)isSelected executes:(enum MSFPopupMenuItemExecutionMode)executionMode onSelected:(void (^ _Nullable)(void))onSelected isAccessoryCheckmarkVisible:(BOOL)isAccessoryCheckmarkVisible;
		[Export ("initWithImageName:generateSelectedImage:title:subtitle:isEnabled:isSelected:executes:onSelected:isAccessoryCheckmarkVisible:")]
		NativeHandle Constructor (string imageName, bool generateSelectedImage, string title, [NullAllowed] string subtitle, bool isEnabled, bool isSelected, MSFPopupMenuItemExecutionMode executionMode, [NullAllowed] Action onSelected, bool isAccessoryCheckmarkVisible);
	}

// 	// @protocol MSFPopupMenuItemTemplateCell
// 	/*
//   Check whether adding [Model] to this declaration is appropriate.
//   [Model] is used to generate a C# class that implements this protocol,
//   and might be useful for protocols that consumers are supposed to implement,
//   since consumers can subclass the generated class instead of implementing
//   the generated interface. If consumers are not supposed to implement this
//   protocol, then [Model] is redundant and will generate code that will never
//   be used.
// */
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MSFPopupMenuItemTemplateCell
	{
		// @required @property (nonatomic) BOOL preservesSpaceForImage;
		[Abstract]
		[Export ("preservesSpaceForImage")]
		bool PreservesSpaceForImage { get; set; }

		// @required @property (nonatomic, strong) UIColor * _Nullable customSeparatorColor;
		[Abstract]
		[NullAllowed, Export ("customSeparatorColor", ArgumentSemantic.Strong)]
		UIColor CustomSeparatorColor { get; set; }

		// @required @property (nonatomic) enum MSFTableViewCellSeparatorType bottomSeparatorType;
		[Abstract]
		[Export ("bottomSeparatorType", ArgumentSemantic.Assign)]
		MSFTableViewCellSeparatorType BottomSeparatorType { get; set; }

		// @required -(void)setupWithItem:(id<MSFPopupMenuTemplateItem> _Nonnull)item;
		[Abstract]
		[Export ("setupWithItem:")]
		void SetupWithItem (MSFPopupMenuTemplateItem item);

		// @required +(CGFloat)preferredWidthFor:(id<MSFPopupMenuTemplateItem> _Nonnull)item preservingSpaceForImage:(BOOL)preserveSpaceForImage __attribute__((warn_unused_result("")));
		[Static, Abstract]
		[Export ("preferredWidthFor:preservingSpaceForImage:")]
		nfloat PreferredWidthFor (MSFPopupMenuTemplateItem item, bool preserveSpaceForImage);

		// @required +(CGFloat)preferredHeightFor:(id<MSFPopupMenuTemplateItem> _Nonnull)item __attribute__((warn_unused_result("")));
		[Static, Abstract]
		[Export ("preferredHeightFor:")]
		nfloat PreferredHeightFor (MSFPopupMenuTemplateItem item);
	}

// 	// @interface MSFPopupMenuSection : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MSFPopupMenuSection
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable title;
		[NullAllowed, Export ("title")]
		string Title { get; }

		// @property (copy, nonatomic) NSArray<id<MSFPopupMenuTemplateItem>> * _Nonnull items;
		[Export ("items", ArgumentSemantic.Copy)]
		MSFPopupMenuTemplateItem[] Items { get; set; }

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nullable)title items:(NSArray<id<MSFPopupMenuTemplateItem>> * _Nonnull)items __attribute__((objc_designated_initializer));
		[Export ("initWithTitle:items:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] string title, MSFPopupMenuTemplateItem[] items);
	}

// 	// @interface MSFResizingHandleView : UIView
	[BaseType (typeof(UIView))]
	interface MSFResizingHandleView
	{
		// @property (readonly, nonatomic, class) CGFloat height;
		[Static]
		[Export ("height")]
		nfloat Height { get; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result("")));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();
	}

// 	// @interface MSFSearchBar : UIView
	[BaseType (typeof(UIView))]
	interface MSFSearchBar
	{
		// @property (nonatomic) BOOL hidesNavigationBarDuringSearch;
		[Export ("hidesNavigationBarDuringSearch")]
		bool HidesNavigationBarDuringSearch { get; set; }

		// @property (nonatomic) CGFloat cornerRadius;
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable placeholderText;
		[NullAllowed, Export ("placeholderText")]
		string PlaceholderText { get; set; }

		// @property (nonatomic) enum MSFSearchBarStyle style;
		[Export ("style", ArgumentSemantic.Assign)]
		MSFSearchBarStyle Style { get; set; }

		// @property (readonly, nonatomic) BOOL isActive;
		[Export ("isActive")]
		bool IsActive { get; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MSFSearchBarDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MSFSearchBarDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic) UITextAutocorrectionType autocorrectionType;
		[Export ("autocorrectionType", ArgumentSemantic.Assign)]
		UITextAutocorrectionType AutocorrectionType { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable leadingView;
		[NullAllowed, Export ("leadingView", ArgumentSemantic.Strong)]
		UIView LeadingView { get; set; }

		// @property (nonatomic) BOOL isEditable;
		[Export ("isEditable")]
		bool IsEditable { get; set; }

		// @property (nonatomic, strong) MSFActivityIndicator * _Nonnull progressSpinner;
		[Export ("progressSpinner", ArgumentSemantic.Strong)]
		MSFActivityIndicator ProgressSpinner { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// -(void)didMoveToWindow;
		[Export ("didMoveToWindow")]
		void DidMoveToWindow ();

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result("")));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);

		// -(void)cancelSearch;
		[Export ("cancelSearch")]
		void CancelSearch ();

		// @property (copy, nonatomic) NSString * _Nullable searchText;
		[NullAllowed, Export ("searchText")]
		string SearchText { get; set; }

		// // -(BOOL)becomeFirstResponder __attribute__((warn_unused_result("")));
		// [Export ("becomeFirstResponder")]
		// [Verify (MethodToProperty)]
		// bool BecomeFirstResponder { get; }

		// // -(BOOL)resignFirstResponder __attribute__((warn_unused_result("")));
		// [Export ("resignFirstResponder")]
		// [Verify (MethodToProperty)]
		// bool ResignFirstResponder { get; }

		// @property (readonly, nonatomic) BOOL isFirstResponder;
		[Export ("isFirstResponder")]
		bool IsFirstResponder { get; }
	}

// 	// @interface FluentUI_Swift_3932 (MSFSearchBar) <UITextFieldDelegate>
// 	[Category]
// 	[BaseType (typeof(MSFSearchBar))]
// 	interface MSFSearchBar_FluentUI_Swift_3932 : IUITextFieldDelegate
// 	{
// 		// -(void)textFieldDidBeginEditing:(UITextField * _Nonnull)textField;
// 		[Export ("textFieldDidBeginEditing:")]
// 		void TextFieldDidBeginEditing (UITextField textField);

// 		// -(BOOL)textFieldShouldReturn:(UITextField * _Nonnull)textField __attribute__((warn_unused_result("")));
// 		[Export ("textFieldShouldReturn:")]
// 		bool TextFieldShouldReturn (UITextField textField);

// 		// -(BOOL)textField:(UITextField * _Nonnull)textField shouldChangeCharactersInRange:(NSRange)range replacementString:(NSString * _Nonnull)string __attribute__((warn_unused_result("")));
// 		[Export ("textField:shouldChangeCharactersInRange:replacementString:")]
// 		bool TextField (UITextField textField, NSRange range, string @string);
// 	}

// 	// @protocol MSFSearchBarDelegate
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MSFSearchBarDelegate
	{
		// @required -(void)searchBarDidBeginEditing:(MSFSearchBar * _Nonnull)searchBar;
		[Abstract]
		[Export ("searchBarDidBeginEditing:")]
		void SearchBarDidBeginEditing (MSFSearchBar searchBar);

		// @required -(void)searchBar:(MSFSearchBar * _Nonnull)searchBar didUpdateSearchText:(NSString * _Nullable)newSearchText;
		[Abstract]
		[Export ("searchBar:didUpdateSearchText:")]
		void SearchBar (MSFSearchBar searchBar, [NullAllowed] string newSearchText);

		// @optional -(void)searchBarDidFinishEditing:(MSFSearchBar * _Nonnull)searchBar;
		[Export ("searchBarDidFinishEditing:")]
		void SearchBarDidFinishEditing (MSFSearchBar searchBar);

		// @required -(void)searchBarDidCancel:(MSFSearchBar * _Nonnull)searchBar;
		[Abstract]
		[Export ("searchBarDidCancel:")]
		void SearchBarDidCancel (MSFSearchBar searchBar);

		// @optional -(void)searchBarDidRequestSearch:(MSFSearchBar * _Nonnull)searchBar;
		[Export ("searchBarDidRequestSearch:")]
		void SearchBarDidRequestSearch (MSFSearchBar searchBar);

		// @optional -(void)searchBar:(MSFSearchBar * _Nonnull)searchBar didUpdateLeadingView:(UIView * _Nullable)leadingView;
		[Export ("searchBar:didUpdateLeadingView:")]
		void SearchBar (MSFSearchBar searchBar, [NullAllowed] UIView leadingView);
	}

// 	// @interface MSFSegmentItem : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MSFSegmentItem
	{
		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title isUnread:(BOOL)isUnread;
		[Export ("initWithTitle:isUnread:")]
		NativeHandle Constructor (string title, bool isUnread);

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title image:(UIImage * _Nullable)image isUnread:(BOOL)isUnread __attribute__((objc_designated_initializer));
		[Export ("initWithTitle:image:isUnread:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string title, [NullAllowed] UIImage image, bool isUnread);
	}

// 	// @interface MSFSegmentedControl : UIView
	[BaseType (typeof(UIView))]
	interface MSFSegmentedControl
	{
		// @property (nonatomic) BOOL isAnimated;
		[Export ("isAnimated")]
		bool IsAnimated { get; set; }

		// @property (readonly, nonatomic) NSInteger numberOfSegments;
		[Export ("numberOfSegments")]
		nint NumberOfSegments { get; }

		// @property (nonatomic) BOOL shouldSetEqualWidthForSegments;
		[Export ("shouldSetEqualWidthForSegments")]
		bool ShouldSetEqualWidthForSegments { get; set; }

		// @property (nonatomic) BOOL isFixedWidth;
		[Export ("isFixedWidth")]
		bool IsFixedWidth { get; set; }

		// @property (nonatomic) NSDirectionalEdgeInsets contentInset;
		[Export ("contentInset", ArgumentSemantic.Assign)]
		NSDirectionalEdgeInsets ContentInset { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(MSFSegmentItem * _Nonnull, NSInteger) onSelectAction;
		[NullAllowed, Export ("onSelectAction", ArgumentSemantic.Copy)]
		Action<MSFSegmentItem, nint> OnSelectAction { get; set; }

		// @property (nonatomic) NSInteger selectedSegmentIndex;
		[Export ("selectedSegmentIndex")]
		nint SelectedSegmentIndex { get; set; }

		// -(instancetype _Nonnull)initWithItems:(NSArray<MSFSegmentItem *> * _Nonnull)items style:(enum MSFSegmentedControlStyle)style __attribute__((objc_designated_initializer));
		[Export ("initWithItems:style:")]
		[DesignatedInitializer]
		NativeHandle Constructor (MSFSegmentItem[] items, MSFSegmentedControlStyle style);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// -(void)insertSegment:(MSFSegmentItem * _Nonnull)item at:(NSInteger)index;
		[Export ("insertSegment:at:")]
		void InsertSegment (MSFSegmentItem item, nint index);

		// -(void)removeSegmentAt:(NSInteger)index;
		[Export ("removeSegmentAt:")]
		void RemoveSegmentAt (nint index);

		// -(void)selectSegmentAt:(NSInteger)index animated:(BOOL)animated;
		[Export ("selectSegmentAt:animated:")]
		void SelectSegmentAt (nint index, bool animated);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result("")));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);

		// -(void)didMoveToWindow;
		[Export ("didMoveToWindow")]
		void DidMoveToWindow ();
	}

// 	// @interface FluentUI_Swift_4046 (MSFSegmentedControl) <UIScrollViewDelegate>
// 	[Category]
// 	[BaseType (typeof(MSFSegmentedControl))]
// 	interface MSFSegmentedControl_FluentUI_Swift_4046 : IUIScrollViewDelegate
// 	{
// 		// -(void)scrollViewDidScroll:(UIScrollView * _Nonnull)scrollView;
// 		[Export ("scrollViewDidScroll:")]
// 		void ScrollViewDidScroll (UIScrollView scrollView);
// 	}

// 	// @interface MSFShimmerView : UIView
	[BaseType (typeof(UIView))]
	interface MSFShimmerView
	{
		// @property (nonatomic, weak) id<MSFAnimationSynchronizerProtocol> _Nullable animationSynchronizer;
		[NullAllowed, Export ("animationSynchronizer", ArgumentSemantic.Weak)]
		IMSFAnimationSynchronizerProtocol AnimationSynchronizer { get; set; }

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(instancetype _Nonnull)initWithContainerView:(UIView * _Nullable)containerView excludedViews:(NSArray<UIView *> * _Nonnull)excludedViews animationSynchronizer:(id<MSFAnimationSynchronizerProtocol> _Nullable)animationSynchronizer shimmerStyle:(enum MSFShimmerStyle)shimmerStyle shimmersLeafViews:(BOOL)shimmersLeafViews usesTextHeightForLabels:(BOOL)usesTextHeightForLabels __attribute__((objc_designated_initializer));
		[Export ("initWithContainerView:excludedViews:animationSynchronizer:shimmerStyle:shimmersLeafViews:usesTextHeightForLabels:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] UIView containerView, UIView[] excludedViews, [NullAllowed] IMSFAnimationSynchronizerProtocol animationSynchronizer, MSFShimmerStyle shimmerStyle, bool shimmersLeafViews, bool usesTextHeightForLabels);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder coder);

		// -(void)syncAnimation;
		[Export ("syncAnimation")]
		void SyncAnimation ();
	}

// 	// @interface MSFShimmerLinesView : MSFShimmerView
	[BaseType (typeof(MSFShimmerView))]
	interface MSFShimmerLinesView
	{
		// @property (nonatomic) NSInteger lineCount;
		[Export ("lineCount")]
		nint LineCount { get; set; }

		// @property (nonatomic) CGFloat firstLineFillPercent;
		[Export ("firstLineFillPercent")]
		nfloat FirstLineFillPercent { get; set; }

		// @property (nonatomic) CGFloat lastLineFillPercent;
		[Export ("lastLineFillPercent")]
		nfloat LastLineFillPercent { get; set; }

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result("")));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(instancetype _Nonnull)initWithContainerView:(UIView * _Nullable)containerView excludedViews:(NSArray<UIView *> * _Nonnull)excludedViews animationSynchronizer:(id<MSFAnimationSynchronizerProtocol> _Nullable)animationSynchronizer shimmerStyle:(enum MSFShimmerStyle)shimmerStyle shimmersLeafViews:(BOOL)shimmersLeafViews usesTextHeightForLabels:(BOOL)usesTextHeightForLabels __attribute__((objc_designated_initializer));
		[Export ("initWithContainerView:excludedViews:animationSynchronizer:shimmerStyle:shimmersLeafViews:usesTextHeightForLabels:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] UIView containerView, UIView[] excludedViews, [NullAllowed] IMSFAnimationSynchronizerProtocol animationSynchronizer, MSFShimmerStyle shimmerStyle, bool shimmersLeafViews, bool usesTextHeightForLabels);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder coder);
	}

// 	// @interface MSFSideTabBar : UIView
	[BaseType (typeof(UIView))]
	interface MSFSideTabBar
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MSFSideTabBarDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MSFSideTabBarDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) MSFAvatar * _Nullable avatar;
		[NullAllowed, Export ("avatar", ArgumentSemantic.Strong)]
		MSFAvatar Avatar { get; set; }

		// @property (copy, nonatomic) NSArray<MSFTabBarItem *> * _Nonnull topItems;
		[Export ("topItems", ArgumentSemantic.Copy)]
		MSFTabBarItem[] TopItems { get; set; }

		// @property (copy, nonatomic) NSArray<MSFTabBarItem *> * _Nonnull bottomItems;
		[Export ("bottomItems", ArgumentSemantic.Copy)]
		MSFTabBarItem[] BottomItems { get; set; }

		// @property (nonatomic, strong) MSFTabBarItem * _Nullable selectedTopItem;
		[NullAllowed, Export ("selectedTopItem", ArgumentSemantic.Strong)]
		MSFTabBarItem SelectedTopItem { get; set; }

		// @property (nonatomic) BOOL showTopItemTitles;
		[Export ("showTopItemTitles")]
		bool ShowTopItemTitles { get; set; }

		// @property (nonatomic) BOOL showBottomItemTitles;
		[Export ("showBottomItemTitles")]
		bool ShowBottomItemTitles { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect frame);

		// -(UIView * _Nullable)itemViewWith:(MSFTabBarItem * _Nonnull)item __attribute__((warn_unused_result("")));
		[Export ("itemViewWith:")]
		[return: NullAllowed]
		UIView ItemViewWith (MSFTabBarItem item);
	}

// 	// @protocol MSFSideTabBarDelegate
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MSFSideTabBarDelegate
	{
		// @optional -(void)sideTabBar:(MSFSideTabBar * _Nonnull)sideTabBar didSelect:(MSFTabBarItem * _Nonnull)item fromTop:(BOOL)fromTop;
		[Export ("sideTabBar:didSelect:fromTop:")]
		void DidSelect (MSFSideTabBar sideTabBar, MSFTabBarItem item, bool fromTop);

		// @optional -(void)sideTabBar:(MSFSideTabBar * _Nonnull)sideTabBar didActivate:(MSFAvatar * _Nonnull)avatarView;
		[Export ("sideTabBar:didActivate:")]
		void DidActivate (MSFSideTabBar sideTabBar, MSFAvatar avatarView);
	}

// 	// @interface MSFTabBarItem : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MSFTabBarItem
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; }

		// @property (copy, nonatomic) NSString * _Nullable badgeValue;
		[NullAllowed, Export ("badgeValue")]
		string BadgeValue { get; set; }

		// @property (nonatomic) BOOL isUnreadDotVisible;
		[Export ("isUnreadDotVisible")]
		bool IsUnreadDotVisible { get; set; }

		// -(void)setBadgeNumber:(NSUInteger)number;
		[Export ("setBadgeNumber:")]
		void SetBadgeNumber (nuint number);

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title image:(UIImage * _Nonnull)image;
		[Export ("initWithTitle:image:")]
		NativeHandle Constructor (string title, UIImage image);

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title image:(UIImage * _Nonnull)image selectedImage:(UIImage * _Nullable)selectedImage landscapeImage:(UIImage * _Nullable)landscapeImage landscapeSelectedImage:(UIImage * _Nullable)landscapeSelectedImage;
		[Export ("initWithTitle:image:selectedImage:landscapeImage:landscapeSelectedImage:")]
		NativeHandle Constructor (string title, UIImage image, [NullAllowed] UIImage selectedImage, [NullAllowed] UIImage landscapeImage, [NullAllowed] UIImage landscapeSelectedImage);

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title image:(UIImage * _Nonnull)image selectedImage:(UIImage * _Nullable)selectedImage landscapeImage:(UIImage * _Nullable)landscapeImage landscapeSelectedImage:(UIImage * _Nullable)landscapeSelectedImage largeContentImage:(UIImage * _Nullable)largeContentImage accessibilityLabelBadgeFormatString:(NSString * _Nullable)accessibilityLabelBadgeFormatString __attribute__((objc_designated_initializer));
		[Export ("initWithTitle:image:selectedImage:landscapeImage:landscapeSelectedImage:largeContentImage:accessibilityLabelBadgeFormatString:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string title, UIImage image, [NullAllowed] UIImage selectedImage, [NullAllowed] UIImage landscapeImage, [NullAllowed] UIImage landscapeSelectedImage, [NullAllowed] UIImage largeContentImage, [NullAllowed] string accessibilityLabelBadgeFormatString);
	}

// 	// @interface MSFTabBarView : UIView
	[BaseType (typeof(UIView))]
	interface MSFTabBarView
	{
		// @property (copy, nonatomic) NSArray<MSFTabBarItem *> * _Nonnull items;
		[Export ("items", ArgumentSemantic.Copy)]
		MSFTabBarItem[] Items { get; set; }

		// @property (nonatomic, strong) MSFTabBarItem * _Nullable selectedItem;
		[NullAllowed, Export ("selectedItem", ArgumentSemantic.Strong)]
		MSFTabBarItem SelectedItem { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MSFTabBarViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MSFTabBarViewDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(void)setCustomSpacing:(CGFloat)spacing after:(MSFTabBarItem * _Nonnull)item;
		[Export ("setCustomSpacing:after:")]
		void SetCustomSpacing (nfloat spacing, MSFTabBarItem item);

		// -(instancetype _Nonnull)initWithShowsItemTitles:(BOOL)showsItemTitles __attribute__((objc_designated_initializer));
		[Export ("initWithShowsItemTitles:")]
		[DesignatedInitializer]
		NativeHandle Constructor (bool showsItemTitles);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);

		// -(UIView * _Nullable)itemViewWith:(MSFTabBarItem * _Nonnull)item __attribute__((warn_unused_result("")));
		[Export ("itemViewWith:")]
		[return: NullAllowed]
		UIView ItemViewWith (MSFTabBarItem item);
	}

// 	// @protocol MSFTabBarViewDelegate
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MSFTabBarViewDelegate
	{
		// @optional -(void)tabBarView:(MSFTabBarView * _Nonnull)tabBarView didSelect:(MSFTabBarItem * _Nonnull)item;
		[Export ("tabBarView:didSelect:")]
		void DidSelect (MSFTabBarView tabBarView, MSFTabBarItem item);
	}

// 	// @interface MSFTableViewCellFileAccessoryView : UIView
	[BaseType (typeof(UIView))]
	interface MSFTableViewCellFileAccessoryView
	{
		// @property (copy, nonatomic) NSDate * _Nullable date;
		[NullAllowed, Export ("date", ArgumentSemantic.Copy)]
		NSDate Date { get; set; }

		// @property (nonatomic) BOOL showSharedStatus;
		[Export ("showSharedStatus")]
		bool ShowSharedStatus { get; set; }

		// @property (nonatomic) BOOL isShared;
		[Export ("isShared")]
		bool IsShared { get; set; }

		// @property (copy, nonatomic) NSArray<MSFFileAccessoryViewAction *> * _Nonnull actions;
		[Export ("actions", ArgumentSemantic.Copy)]
		MSFFileAccessoryViewAction[] Actions { get; set; }

		// @property (nonatomic) NSUInteger minimumActionsCount;
		[Export ("minimumActionsCount")]
		nuint MinimumActionsCount { get; set; }

		// @property (nonatomic) NSUInteger actionsColumnOverlap;
		[Export ("actionsColumnOverlap")]
		nuint ActionsColumnOverlap { get; set; }

		// @property (nonatomic, weak) MSFTableViewCell * _Nullable tableViewCell;
		[NullAllowed, Export ("tableViewCell", ArgumentSemantic.Weak)]
		MSFTableViewCell TableViewCell { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect frame);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();
	}

// 	// @interface MSFTableViewHeaderFooterView : UITableViewHeaderFooterView
	[BaseType (typeof(UITableViewHeaderFooterView))]
	interface MSFTableViewHeaderFooterView
	{
		// @property (readonly, copy, nonatomic, class) NSString * _Nonnull identifier;
		[Static]
		[Export ("identifier")]
		string Identifier { get; }

		// +(CGFloat)heightWithStyle:(enum MSFTableViewHeaderFooterViewStyle)style title:(NSString * _Nonnull)title titleNumberOfLines:(NSInteger)titleNumberOfLines containerWidth:(CGFloat)containerWidth accessoryView:(UIView * _Nullable)accessoryView __attribute__((warn_unused_result("")));
		[Static]
		[Export ("heightWithStyle:title:titleNumberOfLines:containerWidth:accessoryView:")]
		nfloat HeightWithStyle (MSFTableViewHeaderFooterViewStyle style, string title, nint titleNumberOfLines, nfloat containerWidth, [NullAllowed] UIView accessoryView);

		// +(CGFloat)preferredWidthWithStyle:(enum MSFTableViewHeaderFooterViewStyle)style title:(NSString * _Nonnull)title accessoryView:(UIView * _Nullable)accessoryView leadingView:(UIView * _Nullable)leadingView __attribute__((warn_unused_result("")));
		[Static]
		[Export ("preferredWidthWithStyle:title:accessoryView:leadingView:")]
		nfloat PreferredWidthWithStyle (MSFTableViewHeaderFooterViewStyle style, string title, [NullAllowed] UIView accessoryView, [NullAllowed] UIView leadingView);

		// @property (nonatomic) enum MSFTableViewHeaderFooterViewAccessoryButtonStyle accessoryButtonStyle;
		[Export ("accessoryButtonStyle", ArgumentSemantic.Assign)]
		MSFTableViewHeaderFooterViewAccessoryButtonStyle AccessoryButtonStyle { get; set; }

		// @property (nonatomic) NSInteger titleNumberOfLines;
		[Export ("titleNumberOfLines")]
		nint TitleNumberOfLines { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(void) onAccessoryButtonTapped;
		[NullAllowed, Export ("onAccessoryButtonTapped", ArgumentSemantic.Copy)]
		Action OnAccessoryButtonTapped { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(void) onHeaderViewTapped;
		[NullAllowed, Export ("onHeaderViewTapped", ArgumentSemantic.Copy)]
		Action OnHeaderViewTapped { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MSFTableViewHeaderFooterViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MSFTableViewHeaderFooterViewDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// @property (nonatomic) CGRect bounds;
		[Export ("bounds", ArgumentSemantic.Assign)]
		CGRect Bounds { get; set; }

		// @property (nonatomic) CGRect frame;
		[Export ("frame", ArgumentSemantic.Assign)]
		CGRect Frame { get; set; }

		// -(instancetype _Nonnull)initWithReuseIdentifier:(NSString * _Nullable)reuseIdentifier __attribute__((objc_designated_initializer));
		[Export ("initWithReuseIdentifier:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] string reuseIdentifier);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// // -(void)setupWithStyle:(enum MSFTableViewHeaderFooterViewStyle)style title:(NSString * _Nonnull)title accessoryButtonTitle:(NSString * _Nonnull)accessoryButtonTitle;
		// [Export ("setupWithStyle:title:accessoryButtonTitle:")]
		// void SetupWithStyle (MSFTableViewHeaderFooterViewStyle style, string title, string accessoryButtonTitle);

		// -(void)setupWithStyle:(enum MSFTableViewHeaderFooterViewStyle)style title:(NSString * _Nonnull)title accessoryButtonTitle:(NSString * _Nonnull)accessoryButtonTitle leadingView:(UIView * _Nullable)leadingView;
		[Export ("setupWithStyle:title:accessoryButtonTitle:leadingView:")]
		void SetupWithStyle (MSFTableViewHeaderFooterViewStyle style, string title, string accessoryButtonTitle, [NullAllowed] UIView leadingView);

		// // -(void)setupWithStyle:(enum MSFTableViewHeaderFooterViewStyle)style attributedTitle:(NSAttributedString * _Nonnull)attributedTitle accessoryButtonTitle:(NSString * _Nonnull)accessoryButtonTitle;
		// [Export ("setupWithStyle:attributedTitle:accessoryButtonTitle:")]
		// void SetupWithStyle2 (MSFTableViewHeaderFooterViewStyle style, NSAttributedString attributedTitle, string accessoryButtonTitle);

		// -(void)setupWithStyle:(enum MSFTableViewHeaderFooterViewStyle)style attributedTitle:(NSAttributedString * _Nonnull)attributedTitle accessoryButtonTitle:(NSString * _Nonnull)accessoryButtonTitle leadingView:(UIView * _Nullable)leadingView;
		[Export ("setupWithStyle:attributedTitle:accessoryButtonTitle:leadingView:")]
		void SetupWithStyle (MSFTableViewHeaderFooterViewStyle style, NSAttributedString attributedTitle, string accessoryButtonTitle, [NullAllowed] UIView leadingView);

		// // -(void)setupWithStyle:(enum MSFTableViewHeaderFooterViewStyle)style title:(NSString * _Nonnull)title accessoryView:(UIView * _Nonnull)accessoryView;
		// [Export ("setupWithStyle:title:accessoryView:")]
		// void SetupWithStyle (MSFTableViewHeaderFooterViewStyle style, string title, UIView accessoryView);

		// -(void)setupWithStyle:(enum MSFTableViewHeaderFooterViewStyle)style title:(NSString * _Nonnull)title accessoryView:(UIView * _Nonnull)accessoryView leadingView:(UIView * _Nullable)leadingView;
		[Export ("setupWithStyle:title:accessoryView:leadingView:")]
		void SetupWithStyle (MSFTableViewHeaderFooterViewStyle style, string title, UIView accessoryView, [NullAllowed] UIView leadingView);

		// -(void)setupWithStyle:(enum MSFTableViewHeaderFooterViewStyle)style accessoryButtonTitle:(NSString * _Nonnull)accessoryButtonTitle;
		[Export ("setupWithStyle:accessoryButtonTitle:")]
		void SetupWithStyleWithAccessoryButtonTitle (MSFTableViewHeaderFooterViewStyle style, string accessoryButtonTitle);

		// -(void)setupWithStyle:(enum MSFTableViewHeaderFooterViewStyle)style title:(NSString * _Nonnull)title;
		[Export ("setupWithStyle:title:")]
		void SetupWithStyleWithTitle (MSFTableViewHeaderFooterViewStyle style, string title);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)prepareForReuse __attribute__((objc_requires_super));
		[Export ("prepareForReuse")]
		[RequiresSuper]
		void PrepareForReuse ();

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result("")));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);

		// -(void)didMoveToWindow;
		[Export ("didMoveToWindow")]
		void DidMoveToWindow ();
	}

// 	// @interface FluentUI_Swift_4429 (MSFTableViewHeaderFooterView) <UITextViewDelegate>
// 	[Category]
// 	[BaseType (typeof(MSFTableViewHeaderFooterView))]
// 	interface MSFTableViewHeaderFooterView_FluentUI_Swift_4429 : IUITextViewDelegate
// 	{
// 		// -(BOOL)textView:(UITextView * _Nonnull)textView shouldInteractWithURL:(NSURL * _Nonnull)URL inRange:(NSRange)characterRange interaction:(UITextItemInteraction)interaction __attribute__((warn_unused_result("")));
// 		[Export ("textView:shouldInteractWithURL:inRange:interaction:")]
// 		bool TextView (UITextView textView, NSUrl URL, NSRange characterRange, UITextItemInteraction interaction);
// 	}

// 	// @protocol MSFTableViewHeaderFooterViewDelegate
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MSFTableViewHeaderFooterViewDelegate
	{
		// @optional -(BOOL)headerFooterView:(MSFTableViewHeaderFooterView * _Nonnull)headerFooterView shouldInteractWith:(NSURL * _Nonnull)URL in:(NSRange)characterRange interaction:(UITextItemInteraction)interaction __attribute__((warn_unused_result("")));
		[Export ("headerFooterView:shouldInteractWith:in:interaction:")]
		bool ShouldInteractWith (MSFTableViewHeaderFooterView headerFooterView, NSUrl URL, NSRange characterRange, UITextItemInteraction interaction);
	}

// 	// @interface MSFTooltip : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MSFTooltip
	{
		// @property (readonly, nonatomic, class) UIEdgeInsets defaultScreenMargins;
		[Static]
		[Export ("defaultScreenMargins")]
		UIEdgeInsets DefaultScreenMargins { get; }

		// @property (readonly, nonatomic, strong, class) MSFTooltip * _Nonnull shared;
		[Static]
		[Export ("shared", ArgumentSemantic.Strong)]
		MSFTooltip Shared { get; }

		// @property (nonatomic) NSTextAlignment textAlignment;
		[Export ("textAlignment", ArgumentSemantic.Assign)]
		NSTextAlignment TextAlignment { get; set; }

		// @property (readonly, nonatomic) BOOL isShowing;
		[Export ("isShowing")]
		bool IsShowing { get; }

		// -(void)showWith:(NSString * _Nonnull)message for:(UIView * _Nonnull)anchorView preferredArrowDirection:(enum MSFTooltipArrowDirection)preferredArrowDirection offset:(CGPoint)offset screenMargins:(UIEdgeInsets)screenMargins dismissOn:(enum MSFTooltipDismissMode)dismissMode onTap:(void (^ _Nullable)(void))onTap;
		[Export ("showWith:for:preferredArrowDirection:offset:screenMargins:dismissOn:onTap:")]
		void ShowWith (string message, UIView anchorView, MSFTooltipArrowDirection preferredArrowDirection, CGPoint offset, UIEdgeInsets screenMargins, MSFTooltipDismissMode dismissMode, [NullAllowed] Action onTap);

		// -(void)hide;
		[Export ("hide")]
		void Hide ();
	}

// 	// @interface MSFTouchForwardingView : UIView
	[BaseType (typeof(UIView))]
	interface MSFTouchForwardingView
	{
		// -(BOOL)pointInside:(CGPoint)point withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result("")));
		[Export ("pointInside:withEvent:")]
		bool PointInside (CGPoint point, [NullAllowed] UIEvent @event);

		// -(UIView * _Nullable)hitTest:(CGPoint)point withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result("")));
		[Export ("hitTest:withEvent:")]
		[return: NullAllowed]
		UIView HitTest (CGPoint point, [NullAllowed] UIEvent @event);

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder coder);
	}

// 	// @interface MSFTwoLineTitleView : UIView
	[BaseType (typeof(UIView))]
	interface MSFTwoLineTitleView
	{
		// @property (copy, nonatomic) NSString * _Nullable titleAccessibilityHint;
		[NullAllowed, Export ("titleAccessibilityHint")]
		string TitleAccessibilityHint { get; set; }

		// @property (nonatomic) UIAccessibilityTraits titleAccessibilityTraits;
		[Export ("titleAccessibilityTraits")]
		ulong TitleAccessibilityTraits { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable subtitleAccessibilityHint;
		[NullAllowed, Export ("subtitleAccessibilityHint")]
		string SubtitleAccessibilityHint { get; set; }

		// @property (nonatomic) UIAccessibilityTraits subtitleAccessibilityTraits;
		[Export ("subtitleAccessibilityTraits")]
		ulong SubtitleAccessibilityTraits { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MSFTwoLineTitleViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MSFTwoLineTitleViewDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype _Nonnull)initWithStyle:(enum MSFTwoLineTitleViewStyle)style;
		[Export ("initWithStyle:")]
		NativeHandle Constructor (MSFTwoLineTitleViewStyle style);

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		// [Export ("initWithCoder:")]
		// [DesignatedInitializer]
		// NativeHandle Constructor (NSCoder aDecoder);

		// -(void)setupWithTitle:(NSString * _Nonnull)title subtitle:(NSString * _Nullable)subtitle interactivePart:(enum MSFTwoLineTitleViewInteractivePart)interactivePart accessoryType:(enum MSFTwoLineTitleViewAccessoryType)accessoryType;
		[Export ("setupWithTitle:subtitle:interactivePart:accessoryType:")]
		void SetupWithTitle (string title, [NullAllowed] string subtitle, MSFTwoLineTitleViewInteractivePart interactivePart, MSFTwoLineTitleViewAccessoryType accessoryType);

		// -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result("")));
		[Export ("sizeThatFits:")]
		CGSize SizeThatFits (CGSize size);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// @property (nonatomic) BOOL isAccessibilityElement;
		[Export ("isAccessibilityElement")]
		bool IsAccessibilityElement { get; set; }

		// -(NSInteger)accessibilityElementCount __attribute__((swift_attr("@UIActor"))) __attribute__((warn_unused_result("")));
		[Export ("accessibilityElementCount")]
		//[Verify (MethodToProperty)]
		nint AccessibilityElementCount { get; }

		// -(id _Nullable)accessibilityElementAtIndex:(NSInteger)index __attribute__((swift_attr("@UIActor"))) __attribute__((warn_unused_result("")));
		[Export ("accessibilityElementAtIndex:")]
		[return: NullAllowed]
		NSObject AccessibilityElementAtIndex (nint index);

		// -(NSInteger)indexOfAccessibilityElement:(id _Nonnull)element __attribute__((swift_attr("@UIActor"))) __attribute__((warn_unused_result("")));
		[Export ("indexOfAccessibilityElement:")]
		nint IndexOfAccessibilityElement (NSObject element);
	}

// 	// @protocol MSFTwoLineTitleViewDelegate
	[Protocol, Model]
    [BaseType (typeof(NSObject))]
	interface MSFTwoLineTitleViewDelegate
	{
		// @required -(void)twoLineTitleViewDidTapOnTitle:(MSFTwoLineTitleView * _Nonnull)twoLineTitleView;
		[Abstract]
		[Export ("twoLineTitleViewDidTapOnTitle:")]
		void TwoLineTitleViewDidTapOnTitle (MSFTwoLineTitleView twoLineTitleView);
	}

// 	// @interface FluentUI_Swift_4588 (UIBarButtonItem)
// 	[Category]
// 	[BaseType (typeof(UIBarButtonItem))]
// 	interface UIBarButtonItem_FluentUI_Swift_4588
// 	{
// 		// @property (readonly, nonatomic, class) NSNotificationName _Nonnull badgeValueDidChangeNotification;
// 		[Static]
// 		[Export ("badgeValueDidChangeNotification")]
// 		string BadgeValueDidChangeNotification { get; }

// 		// @property (copy, nonatomic) NSString * _Nullable badgeValue;
// 		[NullAllowed, Export ("badgeValue")]
// 		string BadgeValue { get; set; }

// 		// -(void)setBadgeValue:(NSString * _Nullable)badgeValue badgeAccessibilityLabel:(NSString * _Nullable)badgeAccessibilityLabel;
// 		[Export ("setBadgeValue:badgeAccessibilityLabel:")]
// 		void SetBadgeValue ([NullAllowed] string badgeValue, [NullAllowed] string badgeAccessibilityLabel);
// 	}

// 	// @interface FluentUI_Swift_4603 (UIColor)
// 	[Category]
// 	[BaseType (typeof(UIColor))]
// 	interface UIColor_FluentUI_Swift_4603
// 	{
// 		// -(instancetype _Nonnull)initWithLight:(UIColor * _Nonnull)light lightHighContrast:(UIColor * _Nullable)lightHighContrast lightElevated:(UIColor * _Nullable)lightElevated lightElevatedHighContrast:(UIColor * _Nullable)lightElevatedHighContrast dark:(UIColor * _Nullable)dark darkHighContrast:(UIColor * _Nullable)darkHighContrast darkElevated:(UIColor * _Nullable)darkElevated darkElevatedHighContrast:(UIColor * _Nullable)darkElevatedHighContrast;
// 		[Export ("initWithLight:lightHighContrast:lightElevated:lightElevatedHighContrast:dark:darkHighContrast:darkElevated:darkElevatedHighContrast:")]
// 		NativeHandle Constructor (UIColor light, [NullAllowed] UIColor lightHighContrast, [NullAllowed] UIColor lightElevated, [NullAllowed] UIColor lightElevatedHighContrast, [NullAllowed] UIColor dark, [NullAllowed] UIColor darkHighContrast, [NullAllowed] UIColor darkElevated, [NullAllowed] UIColor darkElevatedHighContrast);

// 		// -(instancetype _Nonnull)initWithColorValue:(MSFColorValue * _Nonnull)colorValue;
// 		[Export ("initWithColorValue:")]
// 		NativeHandle Constructor (MSFColorValue colorValue);
// 	}

// 	// @interface FluentUI_Swift_4645 (UINavigationItem)
// 	[Category]
// 	[BaseType (typeof(UINavigationItem))]
// 	interface UINavigationItem_FluentUI_Swift_4645
// 	{
// 		// @property (nonatomic, strong) UIView * _Nullable accessoryView;
// 		[NullAllowed, Export ("accessoryView", ArgumentSemantic.Strong)]
// 		UIView AccessoryView { get; set; }

// 		// @property (nonatomic, strong) UIView * _Nullable topAccessoryView;
// 		[NullAllowed, Export ("topAccessoryView", ArgumentSemantic.Strong)]
// 		UIView TopAccessoryView { get; set; }

// 		// @property (nonatomic, strong) MSFNavigationBarTopAccessoryViewAttributes * _Nullable topAccessoryViewAttributes;
// 		[NullAllowed, Export ("topAccessoryViewAttributes", ArgumentSemantic.Strong)]
// 		MSFNavigationBarTopAccessoryViewAttributes TopAccessoryViewAttributes { get; set; }

// 		// @property (nonatomic, strong) UIScrollView * _Nullable contentScrollView;
// 		[NullAllowed, Export ("contentScrollView", ArgumentSemantic.Strong)]
// 		UIScrollView ContentScrollView { get; set; }

// 		// @property (nonatomic) enum MSFNavigationBarStyle navigationBarStyle;
// 		[Export ("navigationBarStyle", ArgumentSemantic.Assign)]
// 		MSFNavigationBarStyle NavigationBarStyle { get; set; }

// 		// @property (nonatomic) enum MSFNavigationBarShadow navigationBarShadow;
// 		[Export ("navigationBarShadow", ArgumentSemantic.Assign)]
// 		MSFNavigationBarShadow NavigationBarShadow { get; set; }

// 		// @property (nonatomic) BOOL usesLargeTitle;
// 		[Export ("usesLargeTitle")]
// 		bool UsesLargeTitle { get; set; }

// 		// -(UIColor * _Nonnull)navigationBarColorFor:(UIWindow * _Nonnull)window __attribute__((warn_unused_result("")));
// 		[Export ("navigationBarColorFor:")]
// 		UIColor NavigationBarColorFor (UIWindow window);

// 		// @property (nonatomic, strong) UIColor * _Nullable customNavigationBarColor;
// 		[NullAllowed, Export ("customNavigationBarColor", ArgumentSemantic.Strong)]
// 		UIColor CustomNavigationBarColor { get; set; }
// 	}

// 	// @interface FluentUI_Swift_4660 (UIView)
// 	[Category]
// 	[BaseType (typeof(UIView))]
// 	interface UIView_FluentUI_Swift_4660
// 	{
// 		// @property (nonatomic, strong) FluentTheme * _Nonnull fluentTheme;
// 		[Export ("fluentTheme", ArgumentSemantic.Strong)]
// 		FluentTheme FluentTheme { get; set; }
// 	}

// 	// @interface FluentUI_Swift_4668 (UIViewController)
// 	[Category]
// 	[BaseType (typeof(UIViewController))]
// 	interface UIViewController_FluentUI_Swift_4668
// 	{
// 		// @property (readonly, nonatomic, strong) MSFNavigationController * _Nullable msfNavigationController;
// 		[NullAllowed, Export ("msfNavigationController", ArgumentSemantic.Strong)]
// 		MSFNavigationController MsfNavigationController { get; }
// 	}
}