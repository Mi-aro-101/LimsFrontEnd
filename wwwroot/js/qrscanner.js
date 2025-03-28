// Make sure this is also written as a module
export function startScanning(videoElementId, canvasElementId, dotNetHelper) {
    const video = document.getElementById(videoElementId);
    const canvas = document.getElementById(canvasElementId);
    const context = canvas.getContext('2d');

    navigator.mediaDevices.getUserMedia({ video: { facingMode: "environment" } })
        .then(function (stream) {
            video.srcObject = stream;
            video.setAttribute("playsinline", true);
            video.play();

            function tick() {
                if (video.readyState === video.HAVE_ENOUGH_DATA) {
                    canvas.height = video.videoHeight;
                    canvas.width = video.videoWidth;
                    context.drawImage(video, 0, 0, canvas.width, canvas.height);
                    
                    const imageData = context.getImageData(0, 0, canvas.width, canvas.height);
                    const code = jsQR(imageData.data, imageData.width, imageData.height, {
                        inversionAttempts: "dontInvert",
                    });
                    
                    if (code) {
                        dotNetHelper.invokeMethodAsync('OnQRCodeDetected', code.data);
                    }
                }
                requestAnimationFrame(tick);
            }
            tick();
        })
        .catch(function (err) {
            dotNetHelper.invokeMethodAsync('OnError', err.message);
        });

    return {
        stop: function () {
            const stream = video.srcObject;
            const tracks = stream.getTracks();
            tracks.forEach(track => track.stop());
        }
    }
};

export function stopScanning() {
    if (scannerInstance) {
        scannerInstance.stop();
        scannerInstance = null;
    }
}
