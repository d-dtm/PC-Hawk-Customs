﻿

namespace PrimaryQueries {
    class GraphicsCard : Part {
        private string series, chipSet, memory, coreClock;
        public GraphicsCard(int partNumber, string name, double price, string series, string chipSet, string memory, string coreClock) : base(partNumber,name,price) {
            this.series = series;
            this.chipSet = chipSet;
            this.memory = memory;
            this.coreClock = coreClock;
        }
        public string GetSeries() {
            return series;
        }
        public string GetChipSet() {
            return chipSet;
        }
        public string GetMemory() {
            return memory;
        }
        public string GetCoreClock() {
            return coreClock;
        }
    }
}
