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
            type: 'category',  // This is the key change
            categoryorder: 'array', // Preserve your original order
            categoryarray: xs      // Explicitly set all categories
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
