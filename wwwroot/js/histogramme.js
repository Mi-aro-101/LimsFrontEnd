console.log("histogramme.js chargé");

function afficherHistogramme(mois, quantites, titre, unite) {
    console.log("afficherHistogramme appelé avec:", { mois, quantites, titre, unite });

    var trace = {
        x: mois,
        y: quantites,
        type: 'bar',
        marker: { color: 'teal' },
        name: 'Stock'
    };

    var data = [trace];

    var layout = {
        title: {
            text: "📊 " + titre,
            font: {
                size: 28,
                family: "Arial, sans-serif",
                color: "#333"
            },
            xref: "paper",
            x: 0.5,
            y: 0.95
        },
        xaxis: {
            type: 'category',
            title: 'Mois'
        },
        yaxis: {
            title: `Quantité (${unite})`,
            rangemode: 'tozero'
        },
        legend: {
            x: 1,
            y: 1,
            bgcolor: 'rgba(255,255,255,0.5)',
            bordercolor: 'black',
            borderwidth: 1
        }
    };

    Plotly.newPlot('histogrammeDiv', data, layout);
}

window.afficherHistogramme = afficherHistogramme;
console.log("afficherHistogramme attaché à window:", window.afficherHistogramme);