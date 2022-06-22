
/**
* Theme: Adminto Admin Template
* Author: Coderthemes
* Morris Chart
*/

!function($) {
    "use strict";

    var MorrisCharts = function() {};

    //creates line chart
    MorrisCharts.prototype.createLineChart = function(element, data, xkey, ykeys, labels, opacity, Pfillcolor, Pstockcolor, lineColors) {
        Morris.Line({
          element: element,
          data: data,
          xkey: xkey,
          ykeys: ykeys,
          labels: labels,
          fillOpacity: opacity,
          pointFillColors: Pfillcolor,
          pointStrokeColors: Pstockcolor,
          behaveLikeLine: true,
          gridLineColor: '#eef0f2',
          hideHover: 'auto',
          lineWidth: '3px',
          pointSize: 0,
          preUnits: '$ ',
          resize: true, //defaulted to true
          lineColors: lineColors
        });
    },
    //creates area chart
    MorrisCharts.prototype.createAreaChart = function(element, pointSize, lineWidth, data, xkey, ykeys, labels, lineColors) {
        Morris.Area({
            element: element,
            pointSize: 0,
            lineWidth: 0,
            data: data,
            xkey: xkey,
            ykeys: ykeys,
            labels: labels,
            hideHover: 'auto',
            resize: true,
            gridLineColor: '#eef0f2',
            lineColors: lineColors
        });
    },
    //creates area chart with dotted
    MorrisCharts.prototype.createAreaChartDotted = function(element, pointSize, lineWidth, data, xkey, ykeys, labels, Pfillcolor, Pstockcolor, lineColors) {
        Morris.Area({
            element: element,
            pointSize: 3,
            lineWidth: 1,
            data: data,
            xkey: xkey,
            ykeys: ykeys,
            labels: labels,
            hideHover: 'auto',
            pointFillColors: Pfillcolor,
            pointStrokeColors: Pstockcolor,
            resize: true,
            gridLineColor: '#eef0f2',
            lineColors: lineColors
        });
    },
    //creates Bar chart
    MorrisCharts.prototype.createBarChart  = function(element, data, xkey, ykeys, labels, lineColors) {
        Morris.Bar({
            element: element,
            data: data,
            xkey: xkey,
            ykeys: ykeys,
            labels: labels,
            hideHover: 'auto',
            resize: true, //defaulted to true
            gridLineColor: '#eeeeee',
            barSizeRatio: 0.4,
            barColors: lineColors
        });
    },
    //creates Stacked chart
    MorrisCharts.prototype.createStackedChart  = function(element, data, xkey, ykeys, labels, lineColors) {
        Morris.Bar({
            element: element,
            data: data,
            xkey: xkey,
            ykeys: ykeys,
            stacked: true,
            labels: labels,
            hideHover: 'auto',
            resize: true, //defaulted to true
            gridLineColor: '#eeeeee',
            barColors: lineColors
        });
    },
    //creates Donut chart
    MorrisCharts.prototype.createDonutChart = function(element, data, colors) {
        Morris.Donut({
            element: element,
            data: data,
            resize: true, //defaulted to true
            colors: colors
        });
    },
    MorrisCharts.prototype.init = function() {

        //create line chart
        var $data  = [
             { y: '1389', a: 50, b: 0 },
            { y: '1390', a: 75, b: 50 },
            { y: '1391', a: 30, b: 80 },
            { y: '1392', a: 50, b: 50 },
            { y: '1393', a: 75, b: 10 },
            { y: '1394', a: 50, b: 40 },
            { y: '1395', a: 75, b: 50 },
            { y: '1396', a: 100, b: 70 }
          ];
        this.createLineChart('morris-line-example', $data, 'y', ['a', 'b'], ['سری آ', 'سری ب'],['0.1'],['#ffffff'],['#999999'], ['#ff8acc', '#5b69bc']);

        //creating area chart
        var $areaData = [
            { y: '1390', a: 10, b: 20 },
            { y: '1391', a: 75,  b: 65 },
            { y: '1392', a: 50,  b: 40 },
            { y: '1393', a: 75,  b: 65 },
            { y: '1394', a: 50,  b: 40 },
            { y: '1395', a: 75,  b: 65 },
            { y: '1396', a: 90, b: 60 }
        ];
        this.createAreaChart('morris-area-example', 0, 0, $areaData, 'y', ['a', 'b'], ['سری آ', 'سری ب'], ['#5b69bc', "#35b8e0"]);

        //creating area chart with dotted
        var $areaDotData = [
            { y: '1390', a: 10, b: 20 },
            { y: '1391', a: 75,  b: 65 },
            { y: '1392', a: 50,  b: 40 },
            { y: '1393', a: 75,  b: 65 },
            { y: '1394', a: 50,  b: 40 },
            { y: '1395', a: 75,  b: 65 },
            { y: '1396', a: 90, b: 60 }
        ];
        this.createAreaChartDotted('morris-area-with-dotted', 0, 0, $areaDotData, 'y', ['a', 'b'], ['سری آ', 'سری ب'],['#ffffff'],['#999999'], ['#5b69bc', "#35b8e0"]);

        //creating bar chart
        var $barData  = [
            { y: '1390', a: 100, b: 90 , c: 40 },
            { y: '1391', a: 75,  b: 65 , c: 20 },
            { y: '1392', a: 50,  b: 40 , c: 50 },
            { y: '1393', a: 75,  b: 65 , c: 95 },
            { y: '1394', a: 50,  b: 40 , c: 22 },
            { y: '1395', a: 75,  b: 65 , c: 56 },
            { y: '1396', a: 100, b: 90 , c: 60 }
        ];
        this.createBarChart('morris-bar-example', $barData, 'y', ['a', 'b', 'c'], ['سری آ', 'سری ب', 'سری پ'], ['#ff8acc', '#5b69bc', "#35b8e0"]);

        //creating Stacked chart
        var $stckedData  = [
            { y: '2005', a: 45, b: 180 },
            { y: '2006', a: 75,  b: 65 },
            { y: '2007', a: 100, b: 90 },
            { y: '1389', a: 75,  b: 65 },
            { y: '1390', a: 100, b: 90 },
            { y: '1391', a: 75,  b: 65 },
            { y: '1392', a: 50,  b: 40 },
            { y: '1393', a: 75,  b: 65 },
            { y: '1394', a: 50,  b: 40 },
            { y: '1395', a: 75,  b: 65 },
            { y: '1396', a: 100, b: 90 }
        ];
        this.createStackedChart('morris-bar-stacked', $stckedData, 'y', ['a', 'b'], ['سری آ', 'سری ب'], ['#71b6f9', '#ebeff2']);

        //creating donut chart
        var $donutData = [
                {label: "فروش های دانلودی", value: 12},
                {label: "فروش در فروشگاه", value: 30},
                {label: "فروش های ایمیلی", value: 20}
            ];
        this.createDonutChart('morris-donut-example', $donutData, ['#ff8acc', '#5b69bc', "#35b8e0"]);
    },
    //init
    $.MorrisCharts = new MorrisCharts, $.MorrisCharts.Constructor = MorrisCharts
}(window.jQuery),

//initializing 
function($) {
    "use strict";
    $.MorrisCharts.init();
}(window.jQuery);