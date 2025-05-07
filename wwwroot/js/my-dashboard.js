export function DelaiSubdivisionPie(xs, ys){
    var data = [{
        type: "pie",
        values: xs,
        labels: ys,
        textinfo: "label+percent",
        textposition: "outside",
        automargin: true,
        marker: {
            colors: [
                'rgba(49,130,189,0.7)',  // Bleu avec opacité 0.7 pour "paiement en espèce"
                'rgba(59,12,12,0.5)'     // Rouge foncé avec opacité 0.5 pour "paiement par mobile"
                // Tu peux ajouter d'autres couleurs ici si tu as plus de labels
            ]
        }
    }]
      
    var layout = {
        height: 400,
        width: 400,
        margin: {"t": 0, "b": 0, "l": 0, "r": 0},
        showlegend: true
    }
    
    Plotly.newPlot('PieChart', data, layout)
}

export function DelaiSubdivisionBar(xs, yse, ysm, mse, msm){
    var espece = {
        x: xs,
        y: yse,
        type: 'bar',
        name: 'paiement en espèce',
        marker: {
            color: 'rgb(49,130,189)',
            opacity: 0.7,
        },
        text: mse.map((montant, i) => `Montant: ${montant.toLocaleString()} Ar`), // texte au hover
        hovertemplate: 
            '<b>%{x}</b><br>' + 
            'Nombre paiements: %{y}<br>' +
            '%{text}<extra></extra>',
    };
      
    var mobile = {
        x: xs,
        y: ysm,
        type: 'bar',
        name: 'paiement par mobile',
        marker: {
            color: 'rgb(59, 12, 12)',
            opacity: 0.5
        },
        text: msm.map((montant, i) => `Montant: ${montant.toLocaleString()} Ar`),
        hovertemplate: 
            '<b>%{x}</b><br>' + 
            'Nombre paiements: %{y}<br>' +
            '%{text}<extra></extra>',
    };
      
    var data = [espece, mobile];
      
    var layout = {
        title: {
            text: '📊 Délai accordé' ,  // Main title text
        },
        xaxis: {
            tickangle: -45
        },
        barmode: 'group'
    };

    Plotly.newPlot('BarChart', data, layout)
}

/*export function PaiementLineSubdivision(xs, yse, ysm, ysv){
    var espece = {
        x: xs,
        y: yse,
        mode: 'lines+markers',
        connectgaps: true
    };

    var mobile = {
        x: xs,
        y: ysm,
        mode: 'lines+markers',
        connectgaps: true
    };

    var virement = {
        x: xs,
        y: ysv,
        mode: 'lines+markers',
        connectgaps: true
    };

    var data = [espece, mobile, virement];

    var layout = {
        title: {
            text: '📊 Paiement' ,  // Main title text
        },
        showlegend: false
    };

    Plotly.newPlot('LineChart', data, layout)
}*/

export function PaiementLineSubdivision(xs, yse, ysm, ysv) {
    var espece = {
        x: xs,
        y: yse,
        mode: 'lines+markers',
        name: 'Espèce',
        line: {
            color: 'blue',
            width: 3
        },
        marker: {
            color: 'blue',
            size: 8
        },
        connectgaps: true
    };

    var mobile = {
        x: xs,
        y: ysm,
        mode: 'lines+markers',
        name: 'Mobile Money',
        line: {
            color: 'red',
            width: 3
        },
        marker: {
            color: 'red',
            size: 8
        },
        connectgaps: true
    };

    var virement = {
        x: xs,
        y: ysv,
        mode: 'lines+markers',
        name: 'Virement Bancaire',
        line: {
            color: 'green',
            width: 3
        },
        marker: {
            color: 'green',
            size: 8
        },
        connectgaps: true
    };

    var data = [espece, mobile, virement];

    var layout = {
        title: {
            text: '📊 Paiement par catégorie',
            font: {
                size: 20
            }
        },
        legend: {
            orientation: 'h',
            x: 0.5,
            xanchor: 'center',
            y: -0.2
        },
        xaxis: {
            title: 'Période',
            showgrid: true,
            zeroline: false
        },
        yaxis: {
            title: 'Nombre de paiements',
            showgrid: true,
            zeroline: false
        },
        margin: {
            t: 60,
            b: 80
        },
        height: 400,
        width: 600
    };

    Plotly.newPlot('LineChart', data, layout);
}

export function PaiementPieSubdivision(donnee){
    // Calculer le total des paiements
    var totalPaiements = donnee.reduce((a, b) => a + b, 0);

    var data = [{
        values: donnee,
        labels: ['espèce', 'mobile money', 'virement bancaire'],
        name : 'division du paiement',
        hole: .4,
        type: 'pie',
        marker: {
            colors: ['blue', 'red', 'green']  // Spécifie les couleurs ici
        },
        hovertemplate: 
            '%{label}<br>' +
            '%{percent}<br>' +
            '%{customdata} paiements<extra></extra>',
        customdata: donnee
    }];

    var layout = {
        title: {
            text: 'Paiement par catégorie'
        },
        annotations: [
            {
                font: {
                    size: 18
                },
                showarrow: false,
                text: totalPaiements + " prs",
                x: 0.5,   // Centré horizontalement
                y: 0.5,   // Centré verticalement
                align: 'center'
            }
        ],
        height: 400,
        width: 600,
        showlegend: false
    };

    Plotly.newPlot('PieChart', data, layout);
}