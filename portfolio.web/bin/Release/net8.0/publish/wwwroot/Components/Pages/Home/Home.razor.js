const HomeVue = Vue.createApp({
    data() {
        return {
            techStacksNav: Vue.ref({
                showMain: true
            })
        };
    },
    mounted() {

    },
    methods: {
        TechStacksHandler(showMain){
            this.techStacksNav.showMain = showMain;
        }
    }
});

HomeVue.mount('#home-vue');