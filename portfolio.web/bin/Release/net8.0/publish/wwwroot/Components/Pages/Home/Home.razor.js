const HomeVue = Vue.createApp({
    data() {
        return {
            techStacksNav: Vue.ref({
                showMain: true
            }),
            visibleProject: Vue.ref({
                current: 1,
                maxItem: 5,
                interval: null
            })

        };
    },
    mounted() {
        this.IntervalHandler();
    },
    methods: {
        TechStacksHandler(showMain){
            this.techStacksNav.showMain = showMain;
        },
        IntervalHandler(){
            this.visibleProject.interval = setInterval(() => {
                if(this.visibleProject.current <= this.visibleProject.maxItem){
                    this.visibleProject.current++;
                }else{
                    this.visibleProject.current = 1;
                } 
            }, 3000);
        }
    }
});

HomeVue.mount('#home-vue');