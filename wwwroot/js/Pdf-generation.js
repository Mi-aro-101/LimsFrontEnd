window.downloadPdfFromBase64 = function (base64Data, label) {
    setTimeout(() => {
        try {
            const byteCharacters = atob(base64Data);
            const byteNumbers = new Array(byteCharacters.length);
            for (let i = 0; i < byteCharacters.length; i++) {
                byteNumbers[i] = byteCharacters.charCodeAt(i);
            }
    
            const byteArray = new Uint8Array(byteNumbers);
            const blob = new Blob([byteArray], { type: 'application/pdf' });
            const blobUrl = URL.createObjectURL(blob);
    
            // Ouvre un nouvel onglet avec le PDF
            const newTab = window.open("about:blank");
            if (newTab) {
                newTab.document.write(`
                    <html>
                        <head><title>${label ?? 'document'}</title></head>
                        <body style="margin:0">
                            <iframe src="${blobUrl}" width="100%" height="100%" style="border:none;"></iframe>
                        </body>
                    </html>
                `);
                newTab.document.close();
            } else {
                console.warn("Impossible d'ouvrir une nouvelle fenêtre (bloquée par le navigateur)");
            }
        } catch (error) {
            console.error("Erreur lors de l'ouverture du PDF :", error);
        }
    }, 200); // Délai de 200ms pour éviter que les popups soient bloquées
}