using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjNet;
using GeoAPI.CoordinateSystems;
using SharpMap.Styles;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //AddLocalShp();           
            //AddWmsLayer();

            AddLocalShpAndStyles();
            AddOsm();

            AddTools();
            mapBox1.Map.ZoomToExtents();
            mapBox1.Refresh();

        }

        private void AddLocalShp()
        {
            SharpMap.Layers.VectorLayer vlay = new SharpMap.Layers.VectorLayer("States");
            vlay.DataSource = new SharpMap.Data.Providers.ShapeFile(@"C:\gis-data\msi.shp", true);
            mapBox1.Map.Layers.Add(vlay);
        }

        private void AddTools()
        {
            mapBox1.ActiveTool = SharpMap.Forms.MapBox.Tools.Pan;
        }


        private void AddWmsLayer()
        {
            SharpMap.Layers.WmsLayer wmsL =
                new SharpMap.Layers.WmsLayer("US Cities",
                    "http://sampleserver1.arcgisonline.com/ArcGIS/services/Specialty/ESRI_StatesCitiesRivers_USA/MapServer/WMSServer");
            //Force PNG format. Else we can't see through
            wmsL.SetImageFormat("image/png");
            //Force version 1.1.0
            wmsL.Version = "1.1.0";
            //Add layer named 2 in the service (Cities)
            wmsL.AddLayer("0");
            wmsL.AddLayer("2");
            //Set the SRID
            wmsL.SRID = 4326;
            mapBox1.Map.Layers.Add(wmsL);
        }

        private static IProjectedCoordinateSystem GetEPSG900913(ProjNet.CoordinateSystems.CoordinateSystemFactory csFact)
        {
            List<ProjectionParameter> parameters = new List<ProjectionParameter>();
            parameters.Add(new ProjectionParameter("semi_major", 6378137.0));
            parameters.Add(new ProjectionParameter("semi_minor", 6378137.0));
            parameters.Add(new ProjectionParameter("latitude_of_origin", 0.0));
            parameters.Add(new ProjectionParameter("central_meridian", 0.0));
            parameters.Add(new ProjectionParameter("scale_factor", 1.0));
            parameters.Add(new ProjectionParameter("false_easting", 0.0));
            parameters.Add(new ProjectionParameter("false_northing", 0.0));
            IProjection projection = csFact.CreateProjection("Google Mercator", "mercator_1sp", parameters);
            IGeographicCoordinateSystem wgs84 = csFact.CreateGeographicCoordinateSystem(
                "WGS 84", ProjNet.CoordinateSystems.AngularUnit.Degrees, ProjNet.CoordinateSystems.HorizontalDatum.WGS84, ProjNet.CoordinateSystems.PrimeMeridian.Greenwich,
                new AxisInfo("north", AxisOrientationEnum.North), new AxisInfo("east", AxisOrientationEnum.East)
            );

            IProjectedCoordinateSystem epsg900913 = csFact.CreateProjectedCoordinateSystem("Google Mercator", wgs84, projection, ProjNet.CoordinateSystems.LinearUnit.Metre,
              new AxisInfo("East", AxisOrientationEnum.East), new AxisInfo("North", AxisOrientationEnum.North));

            return epsg900913;
        }

        private void AddOsm()
        {

            mapBox1.Map.BackgroundLayer.Add(new SharpMap.Layers.TileAsyncLayer(new BruTile.Web.OsmTileSource(), "OSM"));

        }

        private void AddLocalShpAndStyles()
        {
            SharpMap.Layers.VectorLayer vlay = new SharpMap.Layers.VectorLayer("States");
            vlay.DataSource = new SharpMap.Data.Providers.ShapeFile(@".\data\states_ugl.shp", true);

            //Create the style for Land
            VectorStyle landStyle = new VectorStyle();
            landStyle.Fill = new SolidBrush(Color.FromArgb(232, 232, 232));

            //Create the style for Water
            VectorStyle waterStyle = new VectorStyle();
            waterStyle.Fill = new SolidBrush(Color.FromArgb(198, 198, 255));

            //Create the map
            Dictionary<string, SharpMap.Styles.IStyle> styles = new Dictionary<string, IStyle>();
            styles.Add("land", landStyle);
            styles.Add("water", waterStyle);

            //Assign the theme
            vlay.Theme = new SharpMap.Rendering.Thematics.UniqueValuesTheme<string>("class", styles, landStyle);

            mapBox1.Map.Layers.Add(vlay);

            ProjNet.CoordinateSystems.Transformations.CoordinateTransformationFactory ctFact = new ProjNet.CoordinateSystems.Transformations.CoordinateTransformationFactory();
            ProjNet.CoordinateSystems.CoordinateSystemFactory csFact = new ProjNet.CoordinateSystems.CoordinateSystemFactory();
            vlay.CoordinateTransformation = ctFact.CreateFromCoordinateSystems(ProjNet.CoordinateSystems.GeographicCoordinateSystem.WGS84, GetEPSG900913(csFact));
            vlay.ReverseCoordinateTransformation = ctFact.CreateFromCoordinateSystems(GetEPSG900913(csFact), ProjNet.CoordinateSystems.GeographicCoordinateSystem.WGS84);
        }
    }
}
