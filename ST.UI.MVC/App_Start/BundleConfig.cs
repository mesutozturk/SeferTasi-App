using System.Web.Optimization;

namespace ST.UI.MVC.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //~/Areas/Yonetim/
            // CSS style (bootstrap/inspinia)
            bundles.Add(new StyleBundle("~/Areas/Yonetim/Content/css").Include(
                "~/Areas/Yonetim/Content/bootstrap.min.css",
                "~/Areas/Yonetim/Content/animate.css",
                "~/Areas/Yonetim/Content/style.css"));

            // Font Awesome icons
            bundles.Add(new StyleBundle("~/Areas/Yonetim/font-awesome/css").Include(
                "~/Areas/Yonetim/fonts/font-awesome/css/font-awesome.min.css", new CssRewriteUrlTransform()));

            // jQuery
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/bundles/jquery").Include(
                "~/Areas/Yonetim/Scripts/jquery-2.1.1.min.js"));

            // jQueryUI CSS
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/Scripts/plugins/jquery-ui/jqueryuiStyles").Include(
                "~/Areas/Yonetim/Scripts/plugins/jquery-ui/jquery-ui.css"));

            // jQueryUI 
            bundles.Add(new StyleBundle("~/Areas/Yonetim/bundles/jqueryui").Include(
                "~/Areas/Yonetim/Scripts/plugins/jquery-ui/jquery-ui.min.js"));

            // Bootstrap
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/bundles/bootstrap").Include(
                "~/Areas/Yonetim/Scripts/bootstrap.min.js"));

            // Inspinia script
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/bundles/inspinia").Include(
                "~/Areas/Yonetim/Scripts/plugins/metisMenu/metisMenu.min.js",
                "~/Areas/Yonetim/Scripts/plugins/pace/pace.min.js",
                "~/Areas/Yonetim/Scripts/app/inspinia.js"));

            // Inspinia skin config script
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/bundles/skinConfig").Include(
                "~/Areas/Yonetim/Scripts/app/skin.config.min.js"));

            // SlimScroll
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/slimScroll").Include(
                "~/Areas/Yonetim/Scripts/plugins/slimscroll/jquery.slimscroll.min.js"));

            // Peity
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/peity").Include(
                "~/Areas/Yonetim/Scripts/plugins/peity/jquery.peity.min.js"));

            // Video responsible
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/videoResponsible").Include(
                "~/Areas/Yonetim/Scripts/plugins/video/responsible-video.js"));

            // Lightbox gallery css styles
            bundles.Add(new StyleBundle("~/Areas/Yonetim/Content/plugins/blueimp/css/").Include(
                "~/Areas/Yonetim/Content/plugins/blueimp/css/blueimp-gallery.min.css"));

            // Lightbox gallery
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/lightboxGallery").Include(
                "~/Areas/Yonetim/Scripts/plugins/blueimp/jquery.blueimp-gallery.min.js"));

            // Sparkline
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/sparkline").Include(
                "~/Areas/Yonetim/Scripts/plugins/sparkline/jquery.sparkline.min.js"));

            // Morriss chart css styles
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/morrisStyles").Include(
                "~/Areas/Yonetim/Content/plugins/morris/morris-0.4.3.min.css"));

            // Morriss chart
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/morris").Include(
                "~/Areas/Yonetim/Scripts/plugins/morris/raphael-2.1.0.min.js",
                "~/Areas/Yonetim/Scripts/plugins/morris/morris.js"));

            // Flot chart
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/flot").Include(
                "~/Areas/Yonetim/Scripts/plugins/flot/jquery.flot.js",
                "~/Areas/Yonetim/Scripts/plugins/flot/jquery.flot.tooltip.min.js",
                "~/Areas/Yonetim/Scripts/plugins/flot/jquery.flot.resize.js",
                "~/Areas/Yonetim/Scripts/plugins/flot/jquery.flot.pie.js",
                "~/Areas/Yonetim/Scripts/plugins/flot/jquery.flot.time.js",
                "~/Areas/Yonetim/Scripts/plugins/flot/jquery.flot.spline.js"));

            // Rickshaw chart
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/rickshaw").Include(
                "~/Areas/Yonetim/Scripts/plugins/rickshaw/vendor/d3.v3.js",
                "~/Areas/Yonetim/Scripts/plugins/rickshaw/rickshaw.min.js"));

            // ChartJS chart
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/chartJs").Include(
                "~/Areas/Yonetim/Scripts/plugins/chartjs/Chart.min.js"));

            // iCheck css styles
            bundles.Add(new StyleBundle("~/Areas/Yonetim/Content/plugins/iCheck/iCheckStyles").Include(
                "~/Areas/Yonetim/Content/plugins/iCheck/custom.css"));

            // iCheck
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/iCheck").Include(
                "~/Areas/Yonetim/Scripts/plugins/iCheck/icheck.min.js"));

            // dataTables css styles
            bundles.Add(new StyleBundle("~/Areas/Yonetim/Content/plugins/dataTables/dataTablesStyles").Include(
                "~/Areas/Yonetim/Content/plugins/dataTables/datatables.min.css"));

            // dataTables 
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/dataTables").Include(
                "~/Areas/Yonetim/Scripts/plugins/dataTables/datatables.min.js"));

            // jeditable 
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/jeditable").Include(
                "~/Areas/Yonetim/Scripts/plugins/jeditable/jquery.jeditable.js"));

            // jqGrid styles
            bundles.Add(new StyleBundle("~/Areas/Yonetim/Content/plugins/jqGrid/jqGridStyles").Include(
                "~/Areas/Yonetim/Content/plugins/jqGrid/ui.jqgrid.css"));

            // jqGrid 
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/jqGrid").Include(
                "~/Areas/Yonetim/Scripts/plugins/jqGrid/i18n/grid.locale-en.js",
                "~/Areas/Yonetim/Scripts/plugins/jqGrid/jquery.jqGrid.min.js"));

            // codeEditor styles
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/codeEditorStyles").Include(
                "~/Areas/Yonetim/Content/plugins/codemirror/codemirror.css",
                "~/Areas/Yonetim/Content/plugins/codemirror/ambiance.css"));

            // codeEditor 
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/codeEditor").Include(
                "~/Areas/Yonetim/Scripts/plugins/codemirror/codemirror.js",
                "~/Areas/Yonetim/Scripts/plugins/codemirror/mode/javascript/javascript.js"));

            // codeEditor 
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/nestable").Include(
                "~/Areas/Yonetim/Scripts/plugins/nestable/jquery.nestable.js"));

            // validate 
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/validate").Include(
                "~/Areas/Yonetim/Scripts/plugins/validate/jquery.validate.min.js"));

            // fullCalendar styles
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/fullCalendarStyles").Include(
                "~/Areas/Yonetim/Content/plugins/fullcalendar/fullcalendar.css"));

            // fullCalendar 
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/fullCalendar").Include(
                "~/Areas/Yonetim/Scripts/plugins/fullcalendar/moment.min.js",
                "~/Areas/Yonetim/Scripts/plugins/fullcalendar/fullcalendar.min.js"));

            // vectorMap 
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/vectorMap").Include(
                "~/Areas/Yonetim/Scripts/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                "~/Areas/Yonetim/Scripts/plugins/jvectormap/jquery-jvectormap-world-mill-en.js"));

            // ionRange styles
            bundles.Add(new StyleBundle("~/Areas/Yonetim/Content/plugins/ionRangeSlider/ionRangeStyles").Include(
                "~/Areas/Yonetim/Content/plugins/ionRangeSlider/ion.rangeSlider.css",
                "~/Areas/Yonetim/Content/plugins/ionRangeSlider/ion.rangeSlider.skinFlat.css"));

            // ionRange 
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/ionRange").Include(
                "~/Areas/Yonetim/Scripts/plugins/ionRangeSlider/ion.rangeSlider.min.js"));

            // dataPicker styles
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/dataPickerStyles").Include(
                "~/Areas/Yonetim/Content/plugins/datapicker/datepicker3.css"));

            // dataPicker 
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/dataPicker").Include(
                "~/Areas/Yonetim/Scripts/plugins/datapicker/bootstrap-datepicker.js"));

            // nouiSlider styles
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/nouiSliderStyles").Include(
                "~/Areas/Yonetim/Content/plugins/nouslider/jquery.nouislider.css"));

            // nouiSlider 
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/nouiSlider").Include(
                "~/Areas/Yonetim/Scripts/plugins/nouslider/jquery.nouislider.min.js"));

            // jasnyBootstrap styles
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/jasnyBootstrapStyles").Include(
                "~/Areas/Yonetim/Content/plugins/jasny/jasny-bootstrap.min.css"));

            // jasnyBootstrap 
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/jasnyBootstrap").Include(
                "~/Areas/Yonetim/Scripts/plugins/jasny/jasny-bootstrap.min.js"));

            // switchery styles
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/switcheryStyles").Include(
                "~/Areas/Yonetim/Content/plugins/switchery/switchery.css"));

            // switchery 
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/switchery").Include(
                "~/Areas/Yonetim/Scripts/plugins/switchery/switchery.js"));

            // chosen styles
            bundles.Add(new StyleBundle("~/Areas/Yonetim/Content/plugins/chosen/chosenStyles").Include(
                "~/Areas/Yonetim/Content/plugins/chosen/chosen.css"));

            // chosen 
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/chosen").Include(
                "~/Areas/Yonetim/Scripts/plugins/chosen/chosen.jquery.js"));

            // knob 
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/knob").Include(
                "~/Areas/Yonetim/Scripts/plugins/jsKnob/jquery.knob.js"));

            // wizardSteps styles
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/wizardStepsStyles").Include(
                "~/Areas/Yonetim/Content/plugins/steps/jquery.steps.css"));

            // wizardSteps 
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/wizardSteps").Include(
                "~/Areas/Yonetim/Scripts/plugins/staps/jquery.steps.min.js"));

            // dropZone styles
            bundles.Add(new StyleBundle("~/Areas/Yonetim/Content/plugins/dropzone/dropZoneStyles").Include(
                "~/Areas/Yonetim/Content/plugins/dropzone/basic.css",
                "~/Areas/Yonetim/Content/plugins/dropzone/dropzone.css"));

            // dropZone 
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/dropZone").Include(
                "~/Areas/Yonetim/Scripts/plugins/dropzone/dropzone.js"));

            // summernote styles
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/summernoteStyles").Include(
                "~/Areas/Yonetim/Content/plugins/summernote/summernote.css",
                "~/Areas/Yonetim/Content/plugins/summernote/summernote-bs3.css"));

            // summernote 
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/summernote").Include(
                "~/Areas/Yonetim/Scripts/plugins/summernote/summernote.min.js"));

            // toastr notification 
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/toastr").Include(
                "~/Areas/Yonetim/Scripts/plugins/toastr/toastr.min.js"));

            // toastr notification styles
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/toastrStyles").Include(
                "~/Areas/Yonetim/Content/plugins/toastr/toastr.min.css"));

            // color picker
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/colorpicker").Include(
                "~/Areas/Yonetim/Scripts/plugins/colorpicker/bootstrap-colorpicker.min.js"));

            // color picker styles
            bundles.Add(new StyleBundle("~/Areas/Yonetim/Content/plugins/colorpicker/colorpickerStyles").Include(
                "~/Areas/Yonetim/Content/plugins/colorpicker/bootstrap-colorpicker.min.css"));

            // image cropper
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/imagecropper").Include(
                "~/Areas/Yonetim/Scripts/plugins/cropper/cropper.min.js"));

            // image cropper styles
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/imagecropperStyles").Include(
                "~/Areas/Yonetim/Content/plugins/cropper/cropper.min.css"));

            // jsTree
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/jsTree").Include(
                "~/Areas/Yonetim/Scripts/plugins/jsTree/jstree.min.js"));

            // jsTree styles
            bundles.Add(new StyleBundle("~/Areas/Yonetim/Content/plugins/jsTree").Include(
                "~/Areas/Yonetim/Content/plugins/jsTree/style.css"));

            // Diff
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/diff").Include(
                "~/Areas/Yonetim/Scripts/plugins/diff_match_patch/javascript/diff_match_patch.js",
                "~/Areas/Yonetim/Scripts/plugins/preetyTextDiff/jquery.pretty-text-diff.min.js"));

            // Idle timer
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/idletimer").Include(
                "~/Areas/Yonetim/Scripts/plugins/idle-timer/idle-timer.min.js"));

            // Tinycon
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/tinycon").Include(
                "~/Areas/Yonetim/Scripts/plugins/tinycon/tinycon.min.js"));

            // Chartist
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/chartistStyles").Include(
                "~/Areas/Yonetim/Content/plugins/chartist/chartist.min.css"));

            // jsTree styles
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/chartist").Include(
                "~/Areas/Yonetim/Scripts/plugins/chartist/chartist.min.js"));

            // Awesome bootstrap checkbox
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/awesomeCheckboxStyles").Include(
                "~/Areas/Yonetim/Content/plugins/awesome-bootstrap-checkbox/awesome-bootstrap-checkbox.css"));

            // Clockpicker styles
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/clockpickerStyles").Include(
                "~/Areas/Yonetim/Content/plugins/clockpicker/clockpicker.css"));

            // Clockpicker
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/clockpicker").Include(
                "~/Areas/Yonetim/Scripts/plugins/clockpicker/clockpicker.js"));

            // Date range picker Styless
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/dateRangeStyles").Include(
                "~/Areas/Yonetim/Content/plugins/daterangepicker/daterangepicker-bs3.css"));

            // Date range picker
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/dateRange").Include(
                // Date range use moment.js same as full calendar plugin 
                "~/Areas/Yonetim/Scripts/plugins/fullcalendar/moment.min.js",
                "~/Areas/Yonetim/Scripts/plugins/daterangepicker/daterangepicker.js"));

            // Sweet alert Styless
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/sweetAlertStyles").Include(
                "~/Areas/Yonetim/Content/plugins/sweetalert/sweetalert.css"));

            // Sweet alert
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/sweetAlert").Include(
                "~/Areas/Yonetim/Scripts/plugins/sweetalert/sweetalert.min.js"));

            // Footable Styless
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/footableStyles").Include(
                "~/Areas/Yonetim/Content/plugins/footable/footable.core.css", new CssRewriteUrlTransform()));

            // Footable alert
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/footable").Include(
                "~/Areas/Yonetim/Scripts/plugins/footable/footable.all.min.js"));

            // Select2 Styless
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/select2Styles").Include(
                "~/Areas/Yonetim/Content/plugins/select2/select2.min.css"));

            // Select2
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/select2").Include(
                "~/Areas/Yonetim/Scripts/plugins/select2/select2.full.min.js"));

            // Masonry
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/masonry").Include(
                "~/Areas/Yonetim/Scripts/plugins/masonary/masonry.pkgd.min.js"));

            // Slick carousel Styless
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/slickStyles").Include(
                "~/Areas/Yonetim/Content/plugins/slick/slick.css", new CssRewriteUrlTransform()));

            // Slick carousel theme Styless
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/slickThemeStyles").Include(
                "~/Areas/Yonetim/Content/plugins/slick/slick-theme.css", new CssRewriteUrlTransform()));

            // Slick carousel
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/slick").Include(
                "~/Areas/Yonetim/Scripts/plugins/slick/slick.min.js"));

            // Ladda buttons Styless
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/laddaStyles").Include(
                "~/Areas/Yonetim/Content/plugins/ladda/ladda-themeless.min.css"));

            // Ladda buttons
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/ladda").Include(
                "~/Areas/Yonetim/Scripts/plugins/ladda/spin.min.js",
                "~/Areas/Yonetim/Scripts/plugins/ladda/ladda.min.js",
                "~/Areas/Yonetim/Scripts/plugins/ladda/ladda.jquery.min.js"));

            // Dotdotdot buttons
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/truncate").Include(
                "~/Areas/Yonetim/Scripts/plugins/dotdotdot/jquery.dotdotdot.min.js"));

            // Touch Spin Styless
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/touchSpinStyles").Include(
                "~/Areas/Yonetim/Content/plugins/touchspin/jquery.bootstrap-touchspin.min.css"));

            // Touch Spin
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/touchSpin").Include(
                "~/Areas/Yonetim/Scripts/plugins/touchspin/jquery.bootstrap-touchspin.min.js"));

            // Tour Styless
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/tourStyles").Include(
                "~/Areas/Yonetim/Content/plugins/bootstrapTour/bootstrap-tour.min.css"));

            // Tour Spin
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/tour").Include(
                "~/Areas/Yonetim/Scripts/plugins/bootstrapTour/bootstrap-tour.min.js"));

            // i18next Spin
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/i18next").Include(
                "~/Areas/Yonetim/Scripts/plugins/i18next/i18next.min.js"));

            // Clipboard Spin
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/clipboard").Include(
                "~/Areas/Yonetim/Scripts/plugins/clipboard/clipboard.min.js"));

            // c3 Styless
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/c3Styles").Include(
                "~/Areas/Yonetim/Content/plugins/c3/c3.min.css"));

            // c3 Spin
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/c3").Include(
                "~/Areas/Yonetim/Scripts/plugins/c3/c3.min.js"));

            // d3 Spin
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/d3").Include(
                "~/Areas/Yonetim/Scripts/plugins/d3/d3.min.js"));

            // Markdown Styless
            bundles.Add(new StyleBundle("~/Areas/Yonetim/plugins/markdownStyles").Include(
                "~/Areas/Yonetim/Content/plugins/bootstrap-markdown/bootstrap-markdown.min.css"));

            // Markdown Spin
            bundles.Add(new ScriptBundle("~/Areas/Yonetim/plugins/markdown").Include(
                "~/Areas/Yonetim/Scripts/plugins/bootstrap-markdown/bootstrap-markdown.js",
                "~/Areas/Yonetim/Scripts/plugins/bootstrap-markdown/markdown.js"));


        }
    }
}