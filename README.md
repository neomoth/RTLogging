# Neomoth.RTLogging

Hierarchical, named "sawmill" loggers built on Serilog, with console and file handlers.
Ripped straight from [RobustToolbox](https://github.com/space-wizards/RobustToolbox).

```
dotnet add package Neomoth.RTLogging
```

## Usage

```csharp
using RTLogging;

using var logManager = new LogManager();
logManager.RootSawmill.AddHandler(new ConsoleLogHandler());
logManager.RootSawmill.AddHandler(new FileLogHandler("logs/app.log"));

var sawmill = logManager.GetSawmill("game.net");
sawmill.Info("Connected to {0}", "127.0.0.1");
sawmill.Debug("only shown if the level allows it");
```

Sawmills are parented by name: messages logged to `game.net` also reach the handlers on `game` and the root sawmill, and a sawmill with no `Level` set uses its parent's.
