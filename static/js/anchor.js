function scrollToUrlAnchor() {
    if (window.location.hash) {
        window.scrollTop = document.querySelector(window.location.hash).offsetTop;
    }
}