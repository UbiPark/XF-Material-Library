
# XF.Material Library
A Xamarin.Forms library for Xamarin.Android and Xamarin.iOS to implement [Google's Material Design](https://material.io/design).

#### Getting Started
1. Download the current version through [NuGet](https://www.nuget.org/packages/XF.Material) and install it in your Xamarin.Forms projects.
2. Call the `Material.Init()` method in each project:

```c#
//Xamarin.Forms

public App()
{
    InitializeComponent();
    XF.Material.Material.Init(this);
}

//Xamarin.Android

protected override void OnCreate(Bundle savedInstanceState)
{
    TabLayoutResource = Resource.Layout.Tabbar;
    ToolbarResource = Resource.Layout.Toolbar;

    base.OnCreate(savedInstanceState);

    Xamarin.Forms.Forms.Init(this, savedInstanceState);
    XF.Material.Droid.Material.Init(this, savedInstanceState);

    LoadApplication(new App());
}

//Xamarin.iOS

public override bool FinishedLaunching(UIApplication app, NSDictionary options)
{
    Xamarin.Forms.Forms.Init();
    XF.Material.iOS.Material.Init();
    LoadApplication(new App());

    return base.FinishedLaunching(app, options);
}

```

## Features

### Cards

Cards contain content and actions about a single subject.

| Code | Android  | iOS |
| ------------- | ------------- | ------------- |
| ` <material:MaterialCard CornerRadius="2" Elevation="1" HeightRequest="80" HorizontalOptions="FillAndExpand" /> ` |<img src="https://imgur.com/ewedLPj.jpg" alt="Android card" width="500" />|<img src="https://imgur.com/C2dAeI7.jpg" alt="iOS card" width="550"/> |

<b>Properties:</b>

`MaterialCard` inherits the `Frame` class.
- `Elevation` - By default, this property has a value of 1. As you can see in the above images, as you increase the value, the more visible the shadow becomes.

<b>Usage:</b>

Cards are surfaces that display content and actions on a single topic. They should be easy to scan for relevant and actionable information. Elements, like text and images, should be placed on them in a way that clearly indicates hierarchy.

Read more about cards [here](https://material.io/design/components/cards.html).

### Buttons

Buttons allow users to take actions, and make choices, with a single tap.

| Code | Android  | iOS |
| ------------- | ------------- | ------------- |
| `<material:MaterialButton BackgroundColor="#EAEAEA" HorizontalOptions="Center" Text="Elevated Button" TextColor="Black" VerticalOptions="Center" /> ` |<img src="https://imgur.com/o3ubmaD.jpg" alt="Android button" width="500" />|<img src="https://imgur.com/kjy9rAl.jpg" alt="iOS button" width="550"/> |

<b>Properties:</b>

`MaterialButton` inherits the `Button` class.

1. `ButtonType` - The type of the button. The default value is `Elevated`.

    - `Elevated` - This button will cast a shadow.
    - `Flat` - This button will have no shadow.
    - `Outlined` - This button will have no shadow, has a transparent background, and has a border.
    - `Text` - This button will only show its label. It will not have a shadow, has a transparent background, and no border. *Text buttons has a smaller inner padding as compared to the other button types.*

2. `BackgroundColor` - The color of the button's background. *Outlined and Text button types will always have a transparent background color.*

3. `Image` - The icon to be displayed next to the button's label. The color of the icon will be based on the `TextColor` property value of the button.

4. `AllCaps` - Whether the letters in the label of the button should be in upper case or not. By default, this is set to `true`.

<b>Usage:</b>

- `Elevated` and `Flat`

    <img src="https://imgur.com/9RwKyO2.jpg" alt="contained buttons" width="800" />
    
    These are high-emphasis buttons that are distinguished by their fill color and/or shadow. The actions bound to them are primary to your app.

- `Outlined`

    <img src="https://imgur.com/AGWm9J0.jpg" alt="outlined buttons" width="800" />
    
    These are medium-emphasis buttons. The actions bound to them are important, but are not the primary action in an app.

- `Text`

    <img src="https://imgur.com/mrKZH8c.jpg" alt="outlined buttons" width="800" />
    
    These buttons are typically used for less-pronounced actions, which are located in modal dialogs or in cards.

Read more about buttons [here](https://material.io/design/components/buttons.html).

### Chips
Chips are compact elements that represent an input, attribute, or action.

| Code | Android  | iOS |
| ------------- | ------------- | ------------- |
| `<material:MaterialChip BackgroundColor="#F2F2F2" Image="im_google" Text="Google" TextColor="#DE000000" /> ` |<img src="https://imgur.com/yZ0QMea.jpg" alt="Android button" width="500" />|<img src="https://imgur.com/HTxum8p.jpg" alt="iOS button" width="550"/> |

<b>Properties</b>

`MaterialChip` inherits the `ContentView` class.

1. `Text` - The chip's label to be displayed.

2. `TextColor` - The color of the chip's label.

3. `FontFamily` - The font family of the chip's label.

4. `BackgroundColor` - The color of the chip's background.

5. `Image` - The chip's image to be displayed.

6. `ActionImage` - The chip's action image to be displayed.

7. `ActionImageTappedCommand` - The bindable command that executes when the `ActionImage` of the chip is tapped.

8. `ActionImageTapped` - The event that is called when the `ActionImage` of the chip is tapped.

<b>Usage</b>

Chips allow users to enter information, make selections, filter content, or trigger actions.

Read more about chips [here](https://material.io/design/components/chips.html).


### Adding a shadow to the Navigation Bar
You can add a shadow to the navigation bar by using the `MaterialNavigationPage` control.

### Changing the Status Bar color
You can change the color of the status bar by using the `Material.PlatformConfiguration.ChangeStatusBarColor(Color color)` method.

#### README.md still being updated.
