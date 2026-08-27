using System.Runtime.CompilerServices;
using Serilog.Events;

namespace RTLogging;

public static class LogExt
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static LogLevel ToLevel(this LogEventLevel level) =>
		(LogLevel)level;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static LogEventLevel ToSerilog(this LogLevel level) =>
		(LogEventLevel)level;
}