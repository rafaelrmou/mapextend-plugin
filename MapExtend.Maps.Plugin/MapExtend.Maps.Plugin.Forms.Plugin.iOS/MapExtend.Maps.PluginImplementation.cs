using MapExtend.Maps.Plugin.Forms.Plugin.Abstractions;
using System;
using Xamarin.Forms;
using MapExtend.Maps.Plugin.Forms.Plugin.iOS;

[assembly: Dependency(typeof(MapExtend.Maps.PluginImplementation))]
namespace MapExtend.Maps.Plugin.Forms.Plugin.iOS
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
