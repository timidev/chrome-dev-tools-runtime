# chrome-dev-tools-sample
Sample usage of the [Chrome Developer Protocol](https://developer.chrome.com/devtools/docs/debugger-protocol) using the project generated by [BaristaLabs\chrome-dev-tools](https://github.com/BaristaLabs/chrome-dev-tools)

### Instructions

 - Clone
 - Launch Chrome with debugging enabled at port 9223
 - Run

``` bash
$ git clone https://github.com/BaristaLabs/chrome-dev-tools-sample
$ cd chrome-dev-tools-sample\ChromeDevToolsCLI
$ "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe" --remote-debugging-port=9223
$ dotnet run
```

This is a sample so the intent is to hack away at the code.

### Commands

In general, using an instance of a ChromeSession, submit strongly-typed commands via the SendCommand method.

``` CS
using (var session = new ChromeSession("ws://...")
{
    await session.SendCommand<Page.NavigateCommand, Page.NavigateCommandResponse>(new Page.NavigateCommand
    {
        Url = "http://www.winamp.com"
    });
}
```

### Events

Subscribe to events via the Subscribe method

``` CS
using (var session = new ChromeSession("ws://...")
{
    session.Subscribe<Page.FrameNavigatedEvent>((e) =>
    {
        Console.WriteLine($"Navigated to {e.Frame.Url}");
    });
}
```

note that you may need to send the associated enable command for a particular domain.
As events are asynchronous, you may need to ensure you program is still running when the event occurs or you may miss it.
