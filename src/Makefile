XBUILD=/Applications/Xcode_14.2.0.app/Contents/Developer/usr/bin/xcodebuild
ROOT=$(PWD)
PROJECT_ROOT=$(ROOT)/../external/fluentui-apple
PROJECT_IOS=$(PROJECT_ROOT)/ios/FluentUI.xcodeproj
PROJECT_APPLE=$(PROJECT_ROOT)/macos/xcode/FluentUI.xcodeproj
BUILD_ROOT=$(PROJECT_ROOT)/build
TARGET_IOS="DrasticFluentUIFramework"
TARGET_MAC="FluentUI-macOS"
TARGET_RESOURCES_IOS="FluentUIResources-ios"
TARGET_RESOURCES_MACOS="FluentUIResources-macos"
PROJECTNAME=FluentUI
OUTPUT=$(ROOT)/Build
IOS_FRAMEWORK_PATH=Products/Library/Frameworks/DrasticFluentUIFramework.framework
FRAMEWORK_PATH=Products/@rpath/FluentUI.framework
BUNDLES_PATH=Products/Library/Bundles
FRAMEWORKS=$(ROOT)/Frameworks
FRAMEWORKS_IOS=$(ROOT)/Frameworks/ios
FRAMEWORKS_MAC=$(ROOT)/Frameworks/mac
HEADERS=$(ROOT)/../headers
BINDING_OUTPUT=$(ROOT)/../bindings
BINDING_OUTPUT_MAC=$(ROOT)/../bindings-mac
IOS_SDK=iphoneos16.2
MAC_SDK=macosx13.1

all: iossimulator iosdevice maccatalyst mac xcframework dotnet

build: iossimulator iosdevice maccatalyst mac xcframework

xcframework: xcframework_ios xcframework_mac

pack: build nuget

iossimulator:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT_IOS) -scheme $(TARGET_IOS) -destination "generic/platform=iOS Simulator" -archivePath $(BUILD_ROOT)/simulator.xcarchive -sdk iphonesimulator SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

iosdevice:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT_IOS) -scheme $(TARGET_IOS) -destination "generic/platform=iOS" -archivePath $(BUILD_ROOT)/iOS.xcarchive -sdk iphoneos SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

maccatalyst:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT_IOS) -scheme $(TARGET_IOS) -destination "generic/platform=macOS,variant=Mac Catalyst,name=Any Mac" -archivePath $(BUILD_ROOT)/catalyst.xcarchive SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

ios_bundle:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT_IOS) -scheme $(TARGET_RESOURCES_IOS) -destination "generic/platform=iOS Simulator" -archivePath $(BUILD_ROOT)/ios_bundle.xcarchive -sdk iphonesimulator SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

mac:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT_APPLE) -scheme $(TARGET_MAC) -destination "generic/platform=macOS,name=Any Mac" -archivePath $(BUILD_ROOT)/mac.xcarchive SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

xcframework_mac:
	rm -rf $(BUILD_ROOT)/$(PROJECTNAME)-Mac.xcframework
	$(XBUILD) -create-xcframework -framework $(BUILD_ROOT)/mac.xcarchive/$(FRAMEWORK_PATH) -output $(BUILD_ROOT)/$(PROJECTNAME)-Mac.xcframework
	rm -rf $(FRAMEWORKS)
	mkdir -p $(FRAMEWORKS)
	cp -R $(BUILD_ROOT)/ $(FRAMEWORKS)

xcframework_ios:
	rm -rf $(BUILD_ROOT)/$(PROJECTNAME).xcframework
	$(XBUILD) -create-xcframework -framework $(BUILD_ROOT)/catalyst.xcarchive/$(IOS_FRAMEWORK_PATH) -framework $(BUILD_ROOT)/simulator.xcarchive/$(IOS_FRAMEWORK_PATH) -framework $(BUILD_ROOT)/iOS.xcarchive/$(IOS_FRAMEWORK_PATH) -output $(BUILD_ROOT)/$(PROJECTNAME).xcframework
	rm -rf $(FRAMEWORKS)
	mkdir -p $(FRAMEWORKS)
	cp -R $(BUILD_ROOT)/ $(FRAMEWORKS)

dotnet:
	dotnet build -c Release

nuget:
	dotnet pack --configuration Release

sharpie:
	sharpie bind --sdk=$(IOS_SDK) --output="$(BINDING_OUTPUT)" --namespace="Drastic.$(PROJECTNAME)" --scope="$(HEADERS)" $(HEADERS)/*.h

sharpie_mac:
	sharpie bind --sdk=$(MAC_SDK) --output="$(BINDING_OUTPUT_MAC)" --namespace="Drastic.$(PROJECTNAME).MacOS" --scope="$(BUILD_ROOT)/mac.xcarchive/$(FRAMEWORK_PATH)/Headers" $(BUILD_ROOT)/mac.xcarchive/$(FRAMEWORK_PATH)/Headers/*.h