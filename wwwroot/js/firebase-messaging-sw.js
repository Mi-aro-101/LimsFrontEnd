importScripts('https://www.gstatic.com/firebasejs/9.6.1/firebase-app.js');
importScripts('https://www.gstatic.com/firebasejs/9.6.1/firebase-messaging.js');

// Configuration Firebase
// For Firebase JS SDK v7.20.0 and later, measurementId is optional
const firebaseConfig = {
    apiKey: "AIzaSyBtIDdVB2bgwL9pcmbz15aqO5Ibef--2j8",
    authDomain: "messagerielims.firebaseapp.com",
    projectId: "messagerielims",
    storageBucket: "messagerielims.firebasestorage.app",
    messagingSenderId: "884616988554",
    appId: "1:884616988554:web:bb5561c4dfa35470bf2a73",
    measurementId: "G-7LPSRGT4N0"
  };

firebase.initializeApp(firebaseConfig);
const messaging = firebase.messaging();

messaging.onBackgroundMessage((payload) => {
    console.log("Message en arrière-plan reçu:", payload);

    self.registration.showNotification(payload.notification.title, {
        body: payload.notification.body,
        icon: "/icon.png"
    });
});
