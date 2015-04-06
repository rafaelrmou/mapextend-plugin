using MapExtend.Maps.Plugin.Forms.Plugin.Abstractions;
using System;
using Xamarin.Forms;
using MapExtend.Maps.Plugin.Forms.Plugin.iOSUnified;

[assembly: Dependency(typeof(MapExtend.Maps.PluginImplementation))]
namespace MapExtend.Maps.Plugin.Forms.Plugin.iOSUnified
{
  /// <summary>
  /// MapExtend.Maps.Plugin Implementation
  /// </summary>
  public class MapExtend.Maps.PluginImplementation : IMapExtend.Maps.Plugin
  {
    /// <summary>
    /// Used for registration with dependency service
    /// </summary>
    public static void Init(){}
  }
}
