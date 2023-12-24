function scrollToUrlAnchor() {
    const urlAnchor = window.location.href.split('#')[1];
    if (urlAnchor) {
        console.log(`scrolling to: ${urlAnchor}`);
        window.scrollTop = document.querySelector(`#${urlAnchor}`).offsetTop;
    }
}