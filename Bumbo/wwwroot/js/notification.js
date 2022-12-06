const Notification = {
    show(message, state) {
        clearTimeout(this.hideTimeout);

        this.el = document.getElementById("notification-centre");
        this.el.className = "notification";
        console.log(this.el.className);

        this.el.textContent = message;
        this.el.className = "notification notification--visible";
        console.log(this.el.className);

        if (state) {
            this.el.classList.add(`notification--${state}`);
        }

        this.hideTimeout = setTimeout(() => {
            this.el.classList.remove("notification--visible");
        }, 5000);
    }
};