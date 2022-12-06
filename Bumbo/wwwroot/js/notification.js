const Notification = {
    show(message, state) {
        clearTimeout(this.hideTimeout);

        this.el = document.createElement("div");
        this.el.textContent = message;
        this.el.className = "notification notification--visible";
        document.body.appendChild(this.el);

        if (state) {
            this.el.classList.add(`notification--${state}`);
        }

        this.hideTimeout = setTimeout(() => {
            this.el.remove();
        }, 5000);
    }
};