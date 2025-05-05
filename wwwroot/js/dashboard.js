console.log("dashboard.js chargé");

function afficherDashboard(mois, depensesImmobilisations, depensesReactifs, depensesOutillages, titre) {
    console.log("afficherDashboard appelé avec:", { mois, depensesImmobilisations, depensesReactifs, depensesOutillages, titre });

    var trace1 = {
        x: mois,
        y: depensesImmobilisations,
        name: 'Immobilisations',
        type: 'bar',
        marker: { color: 'blue' }
    };

    var trace2 = {
        x: mois,
        y: depensesReactifs,
        name: 'Réactifs',
        type: 'bar',
        marker: { color: 'green' }
    };

    var trace3 = {
        x: mois,
        y: depensesOutillages,
        name: 'Outillages',
        type: 'bar',
        marker: { color: 'orange' }
    };

    var data = [trace1, trace2, trace3];

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
        barmode: 'group',
        xaxis: {
            type: 'category',
            title: 'Mois'
        },
        yaxis: {
            title: 'Dépenses',
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

    Plotly.newPlot('dashboardDiv', data, layout);
}

window.afficherDashboard = afficherDashboard;
console.log("afficherDashboard attaché à window:", window.afficherDashboard);