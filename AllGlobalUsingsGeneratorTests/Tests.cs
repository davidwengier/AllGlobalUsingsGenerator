using AllGlobalUsingsGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;
using Xunit.Abstractions;

namespace AllGlobalUsingsGeneratorTests;

public class Tests
{
	private readonly ITestOutputHelper _output;

	public Tests(ITestOutputHelper output)
	{
        _output = output;
	}

    [Fact]
    public void Test1()
    {
        string source = @"
namespace Foo
{
    class C
    {
        void M()
        {
        }
    }
}";

        string expected = @"
global using global::AllGlobalUsingsGenerator;
global using global::AllGlobalUsingsGeneratorTests;
global using global::FxResources.Microsoft.CSharp;
global using global::FxResources.Microsoft.VisualBasic.Core;
global using global::FxResources.Microsoft.Win32.Registry;
global using global::FxResources.System.Collections;
global using global::FxResources.System.Collections.Concurrent;
global using global::FxResources.System.Collections.Immutable;
global using global::FxResources.System.Collections.NonGeneric;
global using global::FxResources.System.Collections.Specialized;
global using global::FxResources.System.ComponentModel.Annotations;
global using global::FxResources.System.ComponentModel.EventBasedAsync;
global using global::FxResources.System.ComponentModel.Primitives;
global using global::FxResources.System.ComponentModel.TypeConverter;
global using global::FxResources.System.Console;
global using global::FxResources.System.Data.Common;
global using global::FxResources.System.Diagnostics.DiagnosticSource;
global using global::FxResources.System.Diagnostics.Process;
global using global::FxResources.System.Diagnostics.TextWriterTraceListener;
global using global::FxResources.System.Diagnostics.TraceSource;
global using global::FxResources.System.Drawing.Primitives;
global using global::FxResources.System.Formats.Asn1;
global using global::FxResources.System.IO.Compression;
global using global::FxResources.System.IO.Compression.Brotli;
global using global::FxResources.System.IO.Compression.ZipFile;
global using global::FxResources.System.IO.FileSystem.AccessControl;
global using global::FxResources.System.IO.FileSystem.DriveInfo;
global using global::FxResources.System.IO.FileSystem.Watcher;
global using global::FxResources.System.IO.IsolatedStorage;
global using global::FxResources.System.IO.MemoryMappedFiles;
global using global::FxResources.System.IO.Pipelines;
global using global::FxResources.System.IO.Pipes;
global using global::FxResources.System.Linq;
global using global::FxResources.System.Linq.Expressions;
global using global::FxResources.System.Linq.Parallel;
global using global::FxResources.System.Linq.Queryable;
global using global::FxResources.System.Memory;
global using global::FxResources.System.Net.Http;
global using global::FxResources.System.Net.Http.Json;
global using global::FxResources.System.Net.HttpListener;
global using global::FxResources.System.Net.Mail;
global using global::FxResources.System.Net.NameResolution;
global using global::FxResources.System.Net.NetworkInformation;
global using global::FxResources.System.Net.Ping;
global using global::FxResources.System.Net.Primitives;
global using global::FxResources.System.Net.Quic;
global using global::FxResources.System.Net.Requests;
global using global::FxResources.System.Net.Security;
global using global::FxResources.System.Net.ServicePoint;
global using global::FxResources.System.Net.Sockets;
global using global::FxResources.System.Net.WebClient;
global using global::FxResources.System.Net.WebHeaderCollection;
global using global::FxResources.System.Net.WebSockets;
global using global::FxResources.System.Net.WebSockets.Client;
global using global::FxResources.System.ObjectModel;
global using global::FxResources.System.Private.DataContractSerialization;
global using global::FxResources.System.Private.Uri;
global using global::FxResources.System.Private.Xml;
global using global::FxResources.System.Private.Xml.Linq;
global using global::FxResources.System.Reflection.DispatchProxy;
global using global::FxResources.System.Reflection.Metadata;
global using global::FxResources.System.Reflection.TypeExtensions;
global using global::FxResources.System.Resources.Writer;
global using global::FxResources.System.Runtime.InteropServices;
global using global::FxResources.System.Runtime.InteropServices.RuntimeInformation;
global using global::FxResources.System.Runtime.Numerics;
global using global::FxResources.System.Runtime.Serialization.Formatters;
global using global::FxResources.System.Runtime.Serialization.Primitives;
global using global::FxResources.System.Security.AccessControl;
global using global::FxResources.System.Security.Claims;
global using global::FxResources.System.Security.Cryptography.Algorithms;
global using global::FxResources.System.Security.Cryptography.Cng;
global using global::FxResources.System.Security.Cryptography.Csp;
global using global::FxResources.System.Security.Cryptography.Encoding;
global using global::FxResources.System.Security.Cryptography.OpenSsl;
global using global::FxResources.System.Security.Cryptography.Primitives;
global using global::FxResources.System.Security.Cryptography.X509Certificates;
global using global::FxResources.System.Security.Principal.Windows;
global using global::FxResources.System.Text.Encoding.CodePages;
global using global::FxResources.System.Text.Encodings.Web;
global using global::FxResources.System.Text.Json;
global using global::FxResources.System.Text.RegularExpressions;
global using global::FxResources.System.Threading;
global using global::FxResources.System.Threading.Channels;
global using global::FxResources.System.Threading.Tasks.Dataflow;
global using global::FxResources.System.Threading.Tasks.Parallel;
global using global::FxResources.System.Transactions.Local;
global using global::Humanizer;
global using global::Humanizer.Bytes;
global using global::Humanizer.Configuration;
global using global::Humanizer.DateTimeHumanizeStrategy;
global using global::Humanizer.Inflections;
global using global::Humanizer.Localisation;
global using global::Humanizer.Localisation.CollectionFormatters;
global using global::Humanizer.Localisation.DateToOrdinalWords;
global using global::Humanizer.Localisation.Formatters;
global using global::Humanizer.Localisation.GrammaticalNumber;
global using global::Humanizer.Localisation.NumberToWords;
global using global::Humanizer.Localisation.NumberToWords.Italian;
global using global::Humanizer.Localisation.NumberToWords.Romanian;
global using global::Humanizer.Localisation.Ordinalizers;
global using global::Internal;
global using global::Internal.Cryptography;
global using global::Internal.Cryptography.Pal;
global using global::Internal.Cryptography.Pal.Native;
global using global::Internal.Microsoft.DotNet.PlatformAbstractions;
global using global::Internal.Microsoft.DotNet.PlatformAbstractions.Native;
global using global::Internal.Microsoft.Extensions.DependencyModel;
global using global::Internal.Microsoft.Extensions.DependencyModel.Resolution;
global using global::Internal.NativeCrypto;
global using global::Internal.Runtime.CompilerServices;
global using global::Internal.Runtime.InteropServices;
global using global::Internal.Win32;
global using global::Internal.Win32.SafeHandles;
global using global::Microsoft.Cci;
global using global::Microsoft.CodeAnalysis;
global using global::Microsoft.CodeAnalysis.AddImports;
global using global::Microsoft.CodeAnalysis.CaseCorrection;
global using global::Microsoft.CodeAnalysis.ChangeNamespace;
global using global::Microsoft.CodeAnalysis.Classification;
global using global::Microsoft.CodeAnalysis.Classification.Classifiers;
global using global::Microsoft.CodeAnalysis.CodeActions;
global using global::Microsoft.CodeAnalysis.CodeCleanup;
global using global::Microsoft.CodeAnalysis.CodeCleanup.Providers;
global using global::Microsoft.CodeAnalysis.CodeFixes;
global using global::Microsoft.CodeAnalysis.CodeGen;
global using global::Microsoft.CodeAnalysis.CodeGeneration;
global using global::Microsoft.CodeAnalysis.CodeRefactorings;
global using global::Microsoft.CodeAnalysis.CodeStyle;
global using global::Microsoft.CodeAnalysis.Collections;
global using global::Microsoft.CodeAnalysis.Collections.Internal;
global using global::Microsoft.CodeAnalysis.CSharp;
global using global::Microsoft.CodeAnalysis.CSharp.AddImports;
global using global::Microsoft.CodeAnalysis.CSharp.CaseCorrection;
global using global::Microsoft.CodeAnalysis.CSharp.Classification;
global using global::Microsoft.CodeAnalysis.CSharp.Classification.Classifiers;
global using global::Microsoft.CodeAnalysis.CSharp.Classification.SyntaxClassification;
global using global::Microsoft.CodeAnalysis.CSharp.CodeCleanup;
global using global::Microsoft.CodeAnalysis.CSharp.CodeGen;
global using global::Microsoft.CodeAnalysis.CSharp.CodeGeneration;
global using global::Microsoft.CodeAnalysis.CSharp.CodeStyle;
global using global::Microsoft.CodeAnalysis.CSharp.CodeStyle.TypeStyle;
global using global::Microsoft.CodeAnalysis.CSharp.Diagnostics;
global using global::Microsoft.CodeAnalysis.CSharp.DocumentationComments;
global using global::Microsoft.CodeAnalysis.CSharp.Editing;
global using global::Microsoft.CodeAnalysis.CSharp.EmbeddedLanguages.LanguageServices;
global using global::Microsoft.CodeAnalysis.CSharp.EmbeddedLanguages.VirtualChars;
global using global::Microsoft.CodeAnalysis.CSharp.Emit;
global using global::Microsoft.CodeAnalysis.CSharp.Emit.NoPia;
global using global::Microsoft.CodeAnalysis.CSharp.Extensions;
global using global::Microsoft.CodeAnalysis.CSharp.Extensions.ContextQuery;
global using global::Microsoft.CodeAnalysis.CSharp.FindSymbols;
global using global::Microsoft.CodeAnalysis.CSharp.Formatting;
global using global::Microsoft.CodeAnalysis.CSharp.GeneratedCodeRecognition;
global using global::Microsoft.CodeAnalysis.CSharp.Indentation;
global using global::Microsoft.CodeAnalysis.CSharp.LanguageServices;
global using global::Microsoft.CodeAnalysis.CSharp.MoveDeclarationNearReference;
global using global::Microsoft.CodeAnalysis.CSharp.OrganizeImports;
global using global::Microsoft.CodeAnalysis.CSharp.Precedence;
global using global::Microsoft.CodeAnalysis.CSharp.ReassignedVariable;
global using global::Microsoft.CodeAnalysis.CSharp.Recommendations;
global using global::Microsoft.CodeAnalysis.CSharp.RemoveUnnecessaryImports;
global using global::Microsoft.CodeAnalysis.CSharp.Rename;
global using global::Microsoft.CodeAnalysis.CSharp.ReplaceDiscardDeclarationsWithAssignments;
global using global::Microsoft.CodeAnalysis.CSharp.SemanticModelReuse;
global using global::Microsoft.CodeAnalysis.CSharp.Serialization;
global using global::Microsoft.CodeAnalysis.CSharp.Shared.Extensions;
global using global::Microsoft.CodeAnalysis.CSharp.Shared.Lightup;
global using global::Microsoft.CodeAnalysis.CSharp.Simplification;
global using global::Microsoft.CodeAnalysis.CSharp.Simplification.Simplifiers;
global using global::Microsoft.CodeAnalysis.CSharp.Symbols;
global using global::Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE;
global using global::Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel;
global using global::Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting;
global using global::Microsoft.CodeAnalysis.CSharp.Syntax;
global using global::Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax;
global using global::Microsoft.CodeAnalysis.CSharp.Utilities;
global using global::Microsoft.CodeAnalysis.Debugging;
global using global::Microsoft.CodeAnalysis.DesignerAttribute;
global using global::Microsoft.CodeAnalysis.Diagnostics;
global using global::Microsoft.CodeAnalysis.Diagnostics.Analyzers.NamingStyles;
global using global::Microsoft.CodeAnalysis.Diagnostics.CSharp;
global using global::Microsoft.CodeAnalysis.Diagnostics.Telemetry;
global using global::Microsoft.CodeAnalysis.Differencing;
global using global::Microsoft.CodeAnalysis.Editing;
global using global::Microsoft.CodeAnalysis.Editor.Implementation.TodoComments;
global using global::Microsoft.CodeAnalysis.EditorConfig;
global using global::Microsoft.CodeAnalysis.EditorConfig.Parsing;
global using global::Microsoft.CodeAnalysis.EditorConfig.Parsing.NamingStyles;
global using global::Microsoft.CodeAnalysis.EmbeddedLanguages.Common;
global using global::Microsoft.CodeAnalysis.EmbeddedLanguages.LanguageServices;
global using global::Microsoft.CodeAnalysis.EmbeddedLanguages.VirtualChars;
global using global::Microsoft.CodeAnalysis.Emit;
global using global::Microsoft.CodeAnalysis.Emit.NoPia;
global using global::Microsoft.CodeAnalysis.ErrorLogger;
global using global::Microsoft.CodeAnalysis.ErrorReporting;
global using global::Microsoft.CodeAnalysis.Extensions;
global using global::Microsoft.CodeAnalysis.ExternalAccess.Pythia.Api;
global using global::Microsoft.CodeAnalysis.ExternalAccess.UnitTesting;
global using global::Microsoft.CodeAnalysis.ExternalAccess.UnitTesting.Api;
global using global::Microsoft.CodeAnalysis.ExternalAccess.VSTypeScript.Api;
global using global::Microsoft.CodeAnalysis.FindSymbols;
global using global::Microsoft.CodeAnalysis.FindSymbols.Finders;
global using global::Microsoft.CodeAnalysis.FindSymbols.FindReferences;
global using global::Microsoft.CodeAnalysis.FindSymbols.SymbolTree;
global using global::Microsoft.CodeAnalysis.FlowAnalysis;
global using global::Microsoft.CodeAnalysis.FlowAnalysis.SymbolUsageAnalysis;
global using global::Microsoft.CodeAnalysis.Formatting;
global using global::Microsoft.CodeAnalysis.Formatting.Rules;
global using global::Microsoft.CodeAnalysis.GeneratedCodeRecognition;
global using global::Microsoft.CodeAnalysis.Host;
global using global::Microsoft.CodeAnalysis.Host.Mef;
global using global::Microsoft.CodeAnalysis.Indentation;
global using global::Microsoft.CodeAnalysis.Internal;
global using global::Microsoft.CodeAnalysis.Internal.Log;
global using global::Microsoft.CodeAnalysis.InternalUtilities;
global using global::Microsoft.CodeAnalysis.Interop;
global using global::Microsoft.CodeAnalysis.LanguageServices;
global using global::Microsoft.CodeAnalysis.LanguageServices.TypeInferenceService;
global using global::Microsoft.CodeAnalysis.Logging;
global using global::Microsoft.CodeAnalysis.MoveDeclarationNearReference;
global using global::Microsoft.CodeAnalysis.NamingStyles;
global using global::Microsoft.CodeAnalysis.Notification;
global using global::Microsoft.CodeAnalysis.Operations;
global using global::Microsoft.CodeAnalysis.Options;
global using global::Microsoft.CodeAnalysis.Options.EditorConfig;
global using global::Microsoft.CodeAnalysis.Options.Providers;
global using global::Microsoft.CodeAnalysis.OrganizeImports;
global using global::Microsoft.CodeAnalysis.Packaging;
global using global::Microsoft.CodeAnalysis.PatternMatching;
global using global::Microsoft.CodeAnalysis.PooledObjects;
global using global::Microsoft.CodeAnalysis.Precedence;
global using global::Microsoft.CodeAnalysis.ProjectTelemetry;
global using global::Microsoft.CodeAnalysis.ReassignedVariable;
global using global::Microsoft.CodeAnalysis.Recommendations;
global using global::Microsoft.CodeAnalysis.Remote;
global using global::Microsoft.CodeAnalysis.RemoveUnnecessaryImports;
global using global::Microsoft.CodeAnalysis.Rename;
global using global::Microsoft.CodeAnalysis.Rename.ConflictEngine;
global using global::Microsoft.CodeAnalysis.ReplaceDiscardDeclarationsWithAssignments;
global using global::Microsoft.CodeAnalysis.RuntimeMembers;
global using global::Microsoft.CodeAnalysis.SemanticModelReuse;
global using global::Microsoft.CodeAnalysis.Serialization;
global using global::Microsoft.CodeAnalysis.Shared;
global using global::Microsoft.CodeAnalysis.Shared.Collections;
global using global::Microsoft.CodeAnalysis.Shared.Extensions;
global using global::Microsoft.CodeAnalysis.Shared.Extensions.ContextQuery;
global using global::Microsoft.CodeAnalysis.Shared.TestHooks;
global using global::Microsoft.CodeAnalysis.Shared.Utilities;
global using global::Microsoft.CodeAnalysis.Simplification;
global using global::Microsoft.CodeAnalysis.Simplification.Simplifiers;
global using global::Microsoft.CodeAnalysis.SolutionCrawler;
global using global::Microsoft.CodeAnalysis.SQLite.Interop;
global using global::Microsoft.CodeAnalysis.SQLite.v2;
global using global::Microsoft.CodeAnalysis.SQLite.v2.Interop;
global using global::Microsoft.CodeAnalysis.Storage;
global using global::Microsoft.CodeAnalysis.Storage.CloudCache;
global using global::Microsoft.CodeAnalysis.SymbolDisplay;
global using global::Microsoft.CodeAnalysis.Symbols;
global using global::Microsoft.CodeAnalysis.SymbolSearch;
global using global::Microsoft.CodeAnalysis.Syntax;
global using global::Microsoft.CodeAnalysis.Syntax.InternalSyntax;
global using global::Microsoft.CodeAnalysis.Tags;
global using global::Microsoft.CodeAnalysis.Telemetry;
global using global::Microsoft.CodeAnalysis.Text;
global using global::Microsoft.CodeAnalysis.TodoComments;
global using global::Microsoft.CodeAnalysis.Utilities;
global using global::Microsoft.CodeAnalysis.Workspaces.Diagnostics;
global using global::Microsoft.Composition.Diagnostics;
global using global::Microsoft.CSharp.RuntimeBinder;
global using global::Microsoft.CSharp.RuntimeBinder.ComInterop;
global using global::Microsoft.CSharp.RuntimeBinder.Errors;
global using global::Microsoft.CSharp.RuntimeBinder.Semantics;
global using global::Microsoft.CSharp.RuntimeBinder.Syntax;
global using global::Microsoft.DiaSymReader;
global using global::Microsoft.Extensions.Internal;
global using global::Microsoft.Internal;
global using global::Microsoft.VisualBasic;
global using global::Microsoft.VisualBasic.CompilerServices;
global using global::Microsoft.VisualBasic.FileIO;
global using global::Microsoft.VisualStudio.CodeCoverage;
global using global::Microsoft.VisualStudio.TestPlatform;
global using global::Microsoft.VisualStudio.TestPlatform.Common;
global using global::Microsoft.VisualStudio.TestPlatform.Common.DataCollection;
global using global::Microsoft.VisualStudio.TestPlatform.Common.DataCollector;
global using global::Microsoft.VisualStudio.TestPlatform.Common.DataCollector.Interfaces;
global using global::Microsoft.VisualStudio.TestPlatform.Common.Exceptions;
global using global::Microsoft.VisualStudio.TestPlatform.Common.ExtensionFramework;
global using global::Microsoft.VisualStudio.TestPlatform.Common.ExtensionFramework.Utilities;
global using global::Microsoft.VisualStudio.TestPlatform.Common.Filtering;
global using global::Microsoft.VisualStudio.TestPlatform.Common.Hosting;
global using global::Microsoft.VisualStudio.TestPlatform.Common.Interfaces;
global using global::Microsoft.VisualStudio.TestPlatform.Common.Logging;
global using global::Microsoft.VisualStudio.TestPlatform.Common.Resources;
global using global::Microsoft.VisualStudio.TestPlatform.Common.SettingsProvider;
global using global::Microsoft.VisualStudio.TestPlatform.Common.Telemetry;
global using global::Microsoft.VisualStudio.TestPlatform.Common.Utilities;
global using global::Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
global using global::Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.DataCollection;
global using global::Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.DataCollection.Interfaces;
global using global::Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.EventHandlers;
global using global::Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Interfaces;
global using global::Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
global using global::Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;
global using global::Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;
global using global::Microsoft.VisualStudio.TestPlatform.CoreUtilities;
global using global::Microsoft.VisualStudio.TestPlatform.CoreUtilities.Extensions;
global using global::Microsoft.VisualStudio.TestPlatform.CoreUtilities.Helpers;
global using global::Microsoft.VisualStudio.TestPlatform.CoreUtilities.Resources;
global using global::Microsoft.VisualStudio.TestPlatform.CoreUtilities.Tracing;
global using global::Microsoft.VisualStudio.TestPlatform.CoreUtilities.Tracing.Interfaces;
global using global::Microsoft.VisualStudio.TestPlatform.CrossPlatEngine;
global using global::Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.Adapter;
global using global::Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.Client;
global using global::Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.Client.Parallel;
global using global::Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.DataCollection;
global using global::Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.DataCollection.Interfaces;
global using global::Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.Discovery;
global using global::Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.EventHandlers;
global using global::Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.Execution;
global using global::Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.Helpers;
global using global::Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.Helpers.Interfaces;
global using global::Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.Resources;
global using global::Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.TestRunAttachmentsProcessing;
global using global::Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.Utilities;
global using global::Microsoft.VisualStudio.TestPlatform.ObjectModel;
global using global::Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
global using global::Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
global using global::Microsoft.VisualStudio.TestPlatform.ObjectModel.Client.Interfaces;
global using global::Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
global using global::Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollector.InProcDataCollector;
global using global::Microsoft.VisualStudio.TestPlatform.ObjectModel.Engine;
global using global::Microsoft.VisualStudio.TestPlatform.ObjectModel.Engine.ClientProtocol;
global using global::Microsoft.VisualStudio.TestPlatform.ObjectModel.Engine.TesthostProtocol;
global using global::Microsoft.VisualStudio.TestPlatform.ObjectModel.Host;
global using global::Microsoft.VisualStudio.TestPlatform.ObjectModel.InProcDataCollector;
global using global::Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;
global using global::Microsoft.VisualStudio.TestPlatform.ObjectModel.Navigation;
global using global::Microsoft.VisualStudio.TestPlatform.ObjectModel.Resources;
global using global::Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
global using global::Microsoft.VisualStudio.TestPlatform.PlatformAbstractions;
global using global::Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces;
global using global::Microsoft.VisualStudio.TestPlatform.TestExecutor;
global using global::Microsoft.VisualStudio.TestPlatform.TestHost;
global using global::Microsoft.VisualStudio.TestPlatform.Utilities;
global using global::Microsoft.VisualStudio.TestPlatform.Utilities.Helpers;
global using global::Microsoft.VisualStudio.TestPlatform.Utilities.Helpers.Interfaces;
global using global::Microsoft.VisualStudio.TestPlatform.Utilities.Resources;
global using global::Microsoft.Win32;
global using global::Microsoft.Win32.SafeHandles;
global using global::MS.Internal.Xml.Cache;
global using global::MS.Internal.Xml.Linq.ComponentModel;
global using global::MS.Internal.Xml.XPath;
global using global::Newtonsoft.Json;
global using global::Newtonsoft.Json.Bson;
global using global::Newtonsoft.Json.Converters;
global using global::Newtonsoft.Json.Linq;
global using global::Newtonsoft.Json.Linq.JsonPath;
global using global::Newtonsoft.Json.Schema;
global using global::Newtonsoft.Json.Serialization;
global using global::Newtonsoft.Json.Utilities;
global using global::NuGet.Frameworks;
global using global::NuGet.Shared;
global using global::Roslyn.Collections.Immutable;
global using global::Roslyn.Utilities;
global using global::System;
global using global::System.Buffers;
global using global::System.Buffers.Binary;
global using global::System.Buffers.Text;
global using global::System.CodeDom.Compiler;
global using global::System.Collections;
global using global::System.Collections.Concurrent;
global using global::System.Collections.Generic;
global using global::System.Collections.Immutable;
global using global::System.Collections.ObjectModel;
global using global::System.Collections.Specialized;
global using global::System.ComponentModel;
global using global::System.ComponentModel.DataAnnotations;
global using global::System.ComponentModel.DataAnnotations.Schema;
global using global::System.ComponentModel.Design;
global using global::System.ComponentModel.Design.Serialization;
global using global::System.Composition;
global using global::System.Composition.Convention;
global using global::System.Composition.Debugging;
global using global::System.Composition.Hosting;
global using global::System.Composition.Hosting.Core;
global using global::System.Composition.Hosting.Properties;
global using global::System.Composition.Hosting.Providers;
global using global::System.Composition.Hosting.Providers.CurrentScope;
global using global::System.Composition.Hosting.Providers.ExportFactory;
global using global::System.Composition.Hosting.Providers.ImportMany;
global using global::System.Composition.Hosting.Providers.Lazy;
global using global::System.Composition.Hosting.Providers.Metadata;
global using global::System.Composition.Hosting.Util;
global using global::System.Composition.Properties;
global using global::System.Composition.Runtime.Util;
global using global::System.Composition.TypedParts;
global using global::System.Composition.TypedParts.ActivationFeatures;
global using global::System.Composition.TypedParts.Discovery;
global using global::System.Composition.TypedParts.Util;
global using global::System.Configuration.Assemblies;
global using global::System.Data;
global using global::System.Data.Common;
global using global::System.Data.ProviderBase;
global using global::System.Data.SqlTypes;
global using global::System.Diagnostics;
global using global::System.Diagnostics.CodeAnalysis;
global using global::System.Diagnostics.Contracts;
global using global::System.Diagnostics.Metrics;
global using global::System.Diagnostics.SymbolStore;
global using global::System.Diagnostics.Tracing;
global using global::System.Drawing;
global using global::System.Dynamic;
global using global::System.Dynamic.Utils;
global using global::System.Formats.Asn1;
global using global::System.Globalization;
global using global::System.IO;
global using global::System.IO.Compression;
global using global::System.IO.Enumeration;
global using global::System.IO.IsolatedStorage;
global using global::System.IO.MemoryMappedFiles;
global using global::System.IO.Pipelines;
global using global::System.IO.Pipes;
global using global::System.IO.Strategies;
global using global::System.Linq;
global using global::System.Linq.Expressions;
global using global::System.Linq.Expressions.Compiler;
global using global::System.Linq.Expressions.Interpreter;
global using global::System.Linq.Parallel;
global using global::System.Net;
global using global::System.Net.Cache;
global using global::System.Net.Http;
global using global::System.Net.Http.Headers;
global using global::System.Net.Http.HPack;
global using global::System.Net.Http.Json;
global using global::System.Net.Http.QPack;
global using global::System.Net.Internals;
global using global::System.Net.Mail;
global using global::System.Net.Mime;
global using global::System.Net.NetworkInformation;
global using global::System.Net.Quic;
global using global::System.Net.Quic.Implementations;
global using global::System.Net.Quic.Implementations.Mock;
global using global::System.Net.Quic.Implementations.MsQuic;
global using global::System.Net.Quic.Implementations.MsQuic.Internal;
global using global::System.Net.Security;
global using global::System.Net.Sockets;
global using global::System.Net.WebSockets;
global using global::System.Net.WebSockets.Compression;
global using global::System.Numerics;
global using global::System.Numerics.Hashing;
global using global::System.Private.CoreLib;
global using global::System.Reflection;
global using global::System.Reflection.Emit;
global using global::System.Reflection.Internal;
global using global::System.Reflection.Metadata;
global using global::System.Reflection.Metadata.Ecma335;
global using global::System.Reflection.PortableExecutable;
global using global::System.Resources;
global using global::System.Runtime;
global using global::System.Runtime.CompilerServices;
global using global::System.Runtime.ConstrainedExecution;
global using global::System.Runtime.ExceptionServices;
global using global::System.Runtime.InteropServices;
global using global::System.Runtime.InteropServices.ComTypes;
global using global::System.Runtime.InteropServices.CustomMarshalers;
global using global::System.Runtime.InteropServices.ObjectiveC;
global using global::System.Runtime.Intrinsics;
global using global::System.Runtime.Intrinsics.Arm;
global using global::System.Runtime.Intrinsics.X86;
global using global::System.Runtime.Loader;
global using global::System.Runtime.Remoting;
global using global::System.Runtime.Serialization;
global using global::System.Runtime.Serialization.Formatters;
global using global::System.Runtime.Serialization.Formatters.Binary;
global using global::System.Runtime.Serialization.Json;
global using global::System.Runtime.Versioning;
global using global::System.Security;
global using global::System.Security.AccessControl;
global using global::System.Security.Authentication;
global using global::System.Security.Authentication.ExtendedProtection;
global using global::System.Security.Claims;
global using global::System.Security.Cryptography;
global using global::System.Security.Cryptography.Asn1;
global using global::System.Security.Cryptography.Pkcs;
global using global::System.Security.Cryptography.X509Certificates;
global using global::System.Security.Cryptography.X509Certificates.Asn1;
global using global::System.Security.Permissions;
global using global::System.Security.Policy;
global using global::System.Security.Principal;
global using global::System.StubHelpers;
global using global::System.Text;
global using global::System.Text.Encodings.Web;
global using global::System.Text.Json;
global using global::System.Text.Json.Nodes;
global using global::System.Text.Json.Reflection;
global using global::System.Text.Json.Serialization;
global using global::System.Text.Json.Serialization.Converters;
global using global::System.Text.Json.Serialization.Metadata;
global using global::System.Text.RegularExpressions;
global using global::System.Text.Unicode;
global using global::System.Threading;
global using global::System.Threading.Channels;
global using global::System.Threading.Tasks;
global using global::System.Threading.Tasks.Dataflow;
global using global::System.Threading.Tasks.Dataflow.Internal;
global using global::System.Threading.Tasks.Sources;
global using global::System.Timers;
global using global::System.Transactions;
global using global::System.Transactions.Configuration;
global using global::System.Transactions.Distributed;
global using global::System.Web;
global using global::System.Web.Util;
global using global::System.Windows.Input;
global using global::System.Windows.Markup;
global using global::System.Xml;
global using global::System.Xml.Extensions;
global using global::System.Xml.Linq;
global using global::System.Xml.Resolvers;
global using global::System.Xml.Schema;
global using global::System.Xml.Serialization;
global using global::System.Xml.Serialization.Configuration;
global using global::System.Xml.XPath;
global using global::System.Xml.Xsl;
global using global::System.Xml.Xsl.IlGen;
global using global::System.Xml.Xsl.Qil;
global using global::System.Xml.Xsl.Runtime;
global using global::System.Xml.Xsl.XPath;
global using global::System.Xml.Xsl.Xslt;
global using global::System.Xml.Xsl.XsltOld;
global using global::System.Xml.Xsl.XsltOld.Debugger;
global using global::Xunit;
global using global::Xunit.Abstractions;
global using global::Xunit.Extensions;
global using global::Xunit.Runner.Reporters;
global using global::Xunit.Runner.VisualStudio;
global using global::Xunit.Runners;
global using global::Xunit.Sdk;
global using global::Xunit.Serialization;
";

        string output = GetGeneratedOutput(source);

        Assert.NotNull(output);

        Assert.Equal(expected, output);
    }

    private string GetGeneratedOutput(string source)
    {
        var syntaxTree = CSharpSyntaxTree.ParseText(source);

        var references = new List<MetadataReference>();
        Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
        foreach (var assembly in assemblies)
        {
            if (!assembly.IsDynamic && !string.IsNullOrWhiteSpace(assembly.Location))
            {
                references.Add(MetadataReference.CreateFromFile(assembly.Location));
            }
        }

        var compilation = CSharpCompilation.Create("foo", new SyntaxTree[] { syntaxTree }, references, new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

        IIncrementalGenerator generator = new Generator();

        var driver = CSharpGeneratorDriver.Create(generator);
        driver.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var generateDiagnostics);
        Assert.False(generateDiagnostics.Any(d => d.Severity == DiagnosticSeverity.Error), "Failed: " + generateDiagnostics.FirstOrDefault()?.GetMessage());

        string output = outputCompilation.SyntaxTrees.Last().ToString();

        _output.WriteLine(output);

        return output;
    }
}
