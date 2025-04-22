export function chiffreAffaire(xs, ys, titre)
{
    console.log("X : " +xs)
    console.log("Y : " +ys)
    var x = xs
    var y = ys

    var data = [
        {
            histfunc: "sum",
            y: y,
            x: x,
            type: "bar",
            name: "Profit",
            marker: {
                colors: ['orange', 'blue', 'green', 'red', 'purple', 'yellow', 'brown'] // Same order/colors as above
              }
        }
    ];

    var layout = {
        title: {
            text: "📊 "+titre ,  // Main title text
            font: {
                size: 28,          // Increase size for a bigger title
                family: "Arial, sans-serif",
                color: "#333"       // Title text color
            },
            xref: "paper",
            x: 0.5,               // Centering the title
            y: 0.95
        },
        xaxis: { 
            type: 'category',
            categoryorder: 'array', // Preserve your original order
            categoryarray: x      // Explicitly set all categories
        },
        yaxis: { title: "Profit", rangemode: 'tozero' },
        showlegend: true, // To display the legend
        legend: {
            x: 1,       // Position of the legend (1 = right side)
            y: 1,       // Position of the legend (1 = top)
            bgcolor: 'rgba(255,255,255,0.5)', // Background color of the legend box
            bordercolor: 'black',
            borderwidth: 1
        }
    };

    Plotly.newPlot('myDiv', data, layout)
}

export function chiffreAffaireDepartement(datas, titre)
{
    console.log("Data : " +datas)

    var data = datas;

    var layout = {
        title: {
            text: "📊 "+titre ,  // Main title text
            font: {
                size: 28,          // Increase size for a bigger title
                family: "Arial, sans-serif",
                color: "#333"       // Title text color
            },
            xref: "paper",
            x: 0.5,               // Centering the title
            y: 0.95
        },
        xaxis: { 
            type: 'category',
            categoryorder: 'array', // Preserve your original order
        },
        yaxis: { title: "Profit", rangemode: 'tozero' },
    };

    Plotly.newPlot('myDiv', data, layout)
}

export function chiffreAffaireClient(xs, ys, titre)
{
    var data = [{
        values: ys,
        labels: xs,
        type: 'pie',
        marker: {
            colors: ['blue', 'orange', 'green', 'red', 'purple', 'yellow', 'brown'] // Same order/colors as above
        }
      }];
      
      var layout = {
        height: 400,
        width: 500,
        title: {
            text: "📊 "+titre ,  // Main title text
            font: {
                size: 28,          // Increase size for a bigger title
                family: "Arial, sans-serif",
                color: "#333"       // Title text color
            },
            xref: "paper",
            x: 0.5,               // Centering the title
            y: 0.95
        },
      };
      
      Plotly.newPlot('yourDiv', data, layout);
}
